using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net;
using System.Net.Mail;

namespace MFA_Razonable
{
    public partial class Form1 : Form
    {
        private string generatedOTP;

        private int failedAttempts = 0;
        private DateTime? lockoutEndTime = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtbox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            // Check if the account is locked out
            if (lockoutEndTime.HasValue && DateTime.Now < lockoutEndTime.Value)
            {
                MessageBox.Show("Your account is temporarily locked. Please try again later.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userEmail = txtbox_email.Text;
            string userPassword = txtbox_password.Text;

            if (string.IsNullOrWhiteSpace(userEmail) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Please enter your email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to authenticate the user
            if (!await AuthenticateWithGmail(userEmail, userPassword))
            {
                failedAttempts++;
                if (failedAttempts >= 4)
                {
                    lockoutEndTime = DateTime.Now.AddMinutes(15); // Lockout for 15 minutes
                    MessageBox.Show("Too many failed attempts. Your account is locked for 15 minutes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Incorrect email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            failedAttempts = 0; // Reset failed attempts counter after successful login

            // Send OTP after successful login
            SendOTP(userEmail, userPassword);
        }


        private async Task<bool> AuthenticateWithGmail(string userEmail, string userPassword)
        {
            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(userEmail, userPassword);
                    await client.DisconnectAsync(true);

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void SendOTP(string userEmail, string userPassword)
        {
            Random random = new Random();
            generatedOTP = random.Next(100000, 999999).ToString();

            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("MFA System", userEmail));
                message.To.Add(new MailboxAddress("", userEmail));
                message.Subject = "Your One-Time Password (OTP)";
                message.Body = new TextPart("plain")
                {
                    Text = $"Your OTP is: {generatedOTP}\n\nUse this to complete your login."
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate(userEmail, userPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("OTP Sent! Check your email.", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenOTPForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenOTPForm()
        {
            // Pass the reference to the current Form1 to hide it or close it later
            OTPForm otpForm = new OTPForm(generatedOTP, this);
            otpForm.ShowDialog();
        }
    }
}
