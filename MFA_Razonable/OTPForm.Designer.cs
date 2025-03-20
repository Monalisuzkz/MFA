namespace MFA_Razonable
{
    partial class OTPForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPForm));
            this.txtbox_OTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_VerifyOTP = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtbox_OTP
            // 
            this.txtbox_OTP.BorderRadius = 8;
            this.txtbox_OTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_OTP.DefaultText = "";
            this.txtbox_OTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_OTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_OTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_OTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_OTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_OTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_OTP.ForeColor = System.Drawing.Color.Black;
            this.txtbox_OTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_OTP.Location = new System.Drawing.Point(40, 30);
            this.txtbox_OTP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbox_OTP.Name = "txtbox_OTP";
            this.txtbox_OTP.PasswordChar = '\0';
            this.txtbox_OTP.PlaceholderText = "";
            this.txtbox_OTP.SelectedText = "";
            this.txtbox_OTP.Size = new System.Drawing.Size(300, 57);
            this.txtbox_OTP.TabIndex = 2;
            this.txtbox_OTP.TextChanged += new System.EventHandler(this.txtbox_OTP_TextChanged);
            // 
            // btn_VerifyOTP
            // 
            this.btn_VerifyOTP.BorderRadius = 10;
            this.btn_VerifyOTP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_VerifyOTP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_VerifyOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_VerifyOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_VerifyOTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerifyOTP.ForeColor = System.Drawing.Color.White;
            this.btn_VerifyOTP.Location = new System.Drawing.Point(85, 110);
            this.btn_VerifyOTP.Name = "btn_VerifyOTP";
            this.btn_VerifyOTP.Size = new System.Drawing.Size(207, 58);
            this.btn_VerifyOTP.TabIndex = 5;
            this.btn_VerifyOTP.Text = "VERIFY OTP";
            this.btn_VerifyOTP.Click += new System.EventHandler(this.btn_VerifyOTP_Click);
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(378, 202);
            this.Controls.Add(this.btn_VerifyOTP);
            this.Controls.Add(this.txtbox_OTP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OTPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTP Form";
            this.Load += new System.EventHandler(this.OTPForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtbox_OTP;
        private Guna.UI2.WinForms.Guna2Button btn_VerifyOTP;
    }
}