namespace Demo_3_Layer_Model
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_forgotPassword = new System.Windows.Forms.Label();
            this.label_SignUp = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxChooseRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_forgotPassword
            // 
            this.label_forgotPassword.AutoSize = true;
            this.label_forgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forgotPassword.ForeColor = System.Drawing.Color.Red;
            this.label_forgotPassword.Location = new System.Drawing.Point(496, 259);
            this.label_forgotPassword.Name = "label_forgotPassword";
            this.label_forgotPassword.Size = new System.Drawing.Size(161, 20);
            this.label_forgotPassword.TabIndex = 19;
            this.label_forgotPassword.Text = "Forgot Password?";
            this.label_forgotPassword.Click += new System.EventHandler(this.label_forgotPassword_Click);
            // 
            // label_SignUp
            // 
            this.label_SignUp.AutoSize = true;
            this.label_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.label_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_SignUp.Location = new System.Drawing.Point(442, 364);
            this.label_SignUp.Name = "label_SignUp";
            this.label_SignUp.Size = new System.Drawing.Size(116, 20);
            this.label_SignUp.TabIndex = 18;
            this.label_SignUp.Text = "Sign up now.";
            this.label_SignUp.Click += new System.EventHandler(this.label_SignUp_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(335, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.Location = new System.Drawing.Point(391, 161);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(279, 50);
            this.textBoxPassword.TabIndex = 15;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_GotFocus);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_LostFocus);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.Location = new System.Drawing.Point(391, 98);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(279, 50);
            this.textBoxUsername.TabIndex = 14;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_GotFocus);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_LostFocus);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.Crimson;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(335, 284);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(162, 68);
            this.bt_Cancel.TabIndex = 13;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Login.Location = new System.Drawing.Point(503, 284);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(167, 67);
            this.bt_Login.TabIndex = 12;
            this.bt_Login.Text = "Login\r\n";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxChooseRole
            // 
            this.comboBoxChooseRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseRole.FormattingEnabled = true;
            this.comboBoxChooseRole.Location = new System.Drawing.Point(500, 217);
            this.comboBoxChooseRole.Name = "comboBoxChooseRole";
            this.comboBoxChooseRole.Size = new System.Drawing.Size(170, 39);
            this.comboBoxChooseRole.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select role:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChooseRole);
            this.Controls.Add(this.label_forgotPassword);
            this.Controls.Add(this.label_SignUp);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_forgotPassword;
        private System.Windows.Forms.Label label_SignUp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxChooseRole;
        private System.Windows.Forms.Label label1;
    }
}

