using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFA_Razonable
{
    public partial class OTPForm : Form
    {
        private string correctOTP;
        private Form1 mainForm;

        public OTPForm(string otp, Form1 form)
        {
            InitializeComponent();
            correctOTP = otp;
            mainForm = form; // Save the reference to Form1
        }

        // OTP verification logic
        private void btn_VerifyOTP_Click(object sender, EventArgs e)
        {
            if (txtbox_OTP.Text == correctOTP)
            {
                // OTP verification successful
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the SuccessLogin form
                SuccessLogin successLoginForm = new SuccessLogin();
                successLoginForm.Show();  // Show the SuccessLogin form

                // Option 1: Hide Form1
                mainForm.Hide();  // Hide the login form

                // Option 2: Close Form1 (if you don't want it to stay in memory)
                // mainForm.Close();  // Close the login form

                // Close the OTPForm
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid OTP! Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OTPForm_Load(object sender, EventArgs e)
        {
          
        }

        private void txtbox_OTP_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
