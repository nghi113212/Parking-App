namespace Demo_3_Layer_Model
{
    partial class ForgetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.textBoxOTP = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxVertifyEmail = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_ResetPassword = new System.Windows.Forms.Button();
            this.bt_SendOTP = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOTP.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxOTP.Location = new System.Drawing.Point(192, 320);
            this.textBoxOTP.Multiline = true;
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Size = new System.Drawing.Size(172, 50);
            this.textBoxOTP.TabIndex = 49;
            this.textBoxOTP.Text = "Enter OTP";
            this.textBoxOTP.Enter += new System.EventHandler(this.textBoxOTP_Enter);
            this.textBoxOTP.Leave += new System.EventHandler(this.textBoxOTP_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.Location = new System.Drawing.Point(248, 184);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(278, 50);
            this.textBoxPassword.TabIndex = 48;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(248, 251);
            this.textBoxConfirmPassword.Multiline = true;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(278, 50);
            this.textBoxConfirmPassword.TabIndex = 47;
            this.textBoxConfirmPassword.Text = "Confirm Password";
            this.textBoxConfirmPassword.Enter += new System.EventHandler(this.textBoxConfirmPassword_Enter);
            this.textBoxConfirmPassword.Leave += new System.EventHandler(this.textBoxConfirmPassword_Leave);
            // 
            // textBoxVertifyEmail
            // 
            this.textBoxVertifyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVertifyEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxVertifyEmail.Location = new System.Drawing.Point(248, 113);
            this.textBoxVertifyEmail.Multiline = true;
            this.textBoxVertifyEmail.Name = "textBoxVertifyEmail";
            this.textBoxVertifyEmail.Size = new System.Drawing.Size(278, 49);
            this.textBoxVertifyEmail.TabIndex = 46;
            this.textBoxVertifyEmail.Text = "Your Email";
            this.textBoxVertifyEmail.Enter += new System.EventHandler(this.textBoxVertifyEmail_Enter);
            this.textBoxVertifyEmail.Leave += new System.EventHandler(this.textBoxVertifyEmail_Leave);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(192, 405);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(172, 64);
            this.bt_Cancel.TabIndex = 45;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            this.bt_Cancel.Enter += new System.EventHandler(this.textBoxVertifyEmail_Enter);
            this.bt_Cancel.Leave += new System.EventHandler(this.textBoxVertifyEmail_Leave);
            // 
            // bt_ResetPassword
            // 
            this.bt_ResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ResetPassword.Location = new System.Drawing.Point(370, 405);
            this.bt_ResetPassword.Name = "bt_ResetPassword";
            this.bt_ResetPassword.Size = new System.Drawing.Size(156, 65);
            this.bt_ResetPassword.TabIndex = 44;
            this.bt_ResetPassword.Text = "Reset Password";
            this.bt_ResetPassword.UseVisualStyleBackColor = false;
            this.bt_ResetPassword.Click += new System.EventHandler(this.bt_ResetPassword_Click);
            // 
            // bt_SendOTP
            // 
            this.bt_SendOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SendOTP.ForeColor = System.Drawing.Color.Blue;
            this.bt_SendOTP.Location = new System.Drawing.Point(370, 320);
            this.bt_SendOTP.Name = "bt_SendOTP";
            this.bt_SendOTP.Size = new System.Drawing.Size(156, 50);
            this.bt_SendOTP.TabIndex = 43;
            this.bt_SendOTP.Text = "Send OTP";
            this.bt_SendOTP.UseVisualStyleBackColor = true;
            this.bt_SendOTP.Click += new System.EventHandler(this.bt_SendOTP_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(193, 113);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(193, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(193, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(184, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 48);
            this.label1.TabIndex = 39;
            this.label1.Text = "Forgot Password?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 489);
            this.Controls.Add(this.textBoxOTP);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxVertifyEmail);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_ResetPassword);
            this.Controls.Add(this.bt_SendOTP);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOTP;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxVertifyEmail;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_ResetPassword;
        private System.Windows.Forms.Button bt_SendOTP;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}