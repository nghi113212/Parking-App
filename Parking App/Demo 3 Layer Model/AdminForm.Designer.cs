namespace Demo_3_Layer_Model
{
    partial class AdminForm
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
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.bt_Decline = new System.Windows.Forms.Button();
            this.bt_Accept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bt_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManager.ForeColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonManager.Location = new System.Drawing.Point(680, 404);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(198, 33);
            this.radioButtonManager.TabIndex = 24;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "Role Manager";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdmin.ForeColor = System.Drawing.Color.Red;
            this.radioButtonAdmin.Location = new System.Drawing.Point(680, 355);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(169, 33);
            this.radioButtonAdmin.TabIndex = 23;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Role Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(674, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Permission:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(680, 253);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(479, 40);
            this.textBoxEmail.TabIndex = 21;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(680, 163);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(479, 34);
            this.textBoxPassword.TabIndex = 20;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(680, 77);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(479, 34);
            this.textBoxUsername.TabIndex = 19;
            // 
            // bt_Decline
            // 
            this.bt_Decline.BackColor = System.Drawing.Color.Tomato;
            this.bt_Decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Decline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Decline.Location = new System.Drawing.Point(1035, 379);
            this.bt_Decline.Name = "bt_Decline";
            this.bt_Decline.Size = new System.Drawing.Size(124, 74);
            this.bt_Decline.TabIndex = 18;
            this.bt_Decline.Text = "Decline";
            this.bt_Decline.UseVisualStyleBackColor = false;
            this.bt_Decline.Click += new System.EventHandler(this.bt_Decline_Click);
            // 
            // bt_Accept
            // 
            this.bt_Accept.BackColor = System.Drawing.Color.Lime;
            this.bt_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Accept.ForeColor = System.Drawing.Color.Black;
            this.bt_Accept.Location = new System.Drawing.Point(1035, 299);
            this.bt_Accept.Name = "bt_Accept";
            this.bt_Accept.Size = new System.Drawing.Size(124, 74);
            this.bt_Accept.TabIndex = 17;
            this.bt_Accept.Text = "Accept";
            this.bt_Accept.UseVisualStyleBackColor = false;
            this.bt_Accept.Click += new System.EventHandler(this.bt_Accept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(601, 397);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 506);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(864, 314);
            this.dataGridView2.TabIndex = 25;
            // 
            // bt_Delete
            // 
            this.bt_Delete.BackColor = System.Drawing.Color.Salmon;
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(884, 773);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(142, 47);
            this.bt_Delete.TabIndex = 26;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 832);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.radioButtonManager);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.bt_Decline);
            this.Controls.Add(this.bt_Accept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button bt_Decline;
        private System.Windows.Forms.Button bt_Accept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bt_Delete;
    }
}