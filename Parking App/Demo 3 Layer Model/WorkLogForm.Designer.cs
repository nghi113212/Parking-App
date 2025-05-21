namespace Demo_3_Layer_Model
{
    partial class WorkLogForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxProblemDesc = new System.Windows.Forms.RichTextBox();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxOName = new System.Windows.Forms.TextBox();
            this.textBoxOPhone = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_CompleteTask = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLPlate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Owner name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Owner Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(4, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Problem Description:";
            // 
            // richTextBoxProblemDesc
            // 
            this.richTextBoxProblemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxProblemDesc.Location = new System.Drawing.Point(9, 599);
            this.richTextBoxProblemDesc.Name = "richTextBoxProblemDesc";
            this.richTextBoxProblemDesc.Size = new System.Drawing.Size(403, 221);
            this.richTextBoxProblemDesc.TabIndex = 2;
            this.richTextBoxProblemDesc.Text = "";
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(434, 599);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(384, 221);
            this.richTextBoxNote.TabIndex = 3;
            this.richTextBoxNote.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(429, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Note:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(192, 358);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(297, 34);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxOName
            // 
            this.textBoxOName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOName.Location = new System.Drawing.Point(192, 407);
            this.textBoxOName.Name = "textBoxOName";
            this.textBoxOName.Size = new System.Drawing.Size(297, 34);
            this.textBoxOName.TabIndex = 5;
            // 
            // textBoxOPhone
            // 
            this.textBoxOPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOPhone.Location = new System.Drawing.Point(192, 453);
            this.textBoxOPhone.Name = "textBoxOPhone";
            this.textBoxOPhone.Size = new System.Drawing.Size(297, 34);
            this.textBoxOPhone.TabIndex = 6;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.Location = new System.Drawing.Point(905, 564);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(276, 34);
            this.textBoxCost.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(833, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cost:";
            // 
            // bt_CompleteTask
            // 
            this.bt_CompleteTask.BackColor = System.Drawing.Color.SpringGreen;
            this.bt_CompleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CompleteTask.Location = new System.Drawing.Point(982, 635);
            this.bt_CompleteTask.Name = "bt_CompleteTask";
            this.bt_CompleteTask.Size = new System.Drawing.Size(199, 49);
            this.bt_CompleteTask.TabIndex = 8;
            this.bt_CompleteTask.Text = "Complete task";
            this.bt_CompleteTask.UseVisualStyleBackColor = false;
            this.bt_CompleteTask.Click += new System.EventHandler(this.bt_CompleteTask_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "License Plate:";
            // 
            // textBoxLPlate
            // 
            this.textBoxLPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLPlate.Location = new System.Drawing.Point(192, 501);
            this.textBoxLPlate.Name = "textBoxLPlate";
            this.textBoxLPlate.Size = new System.Drawing.Size(297, 34);
            this.textBoxLPlate.TabIndex = 6;
            // 
            // WorkLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 832);
            this.Controls.Add(this.bt_CompleteTask);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxLPlate);
            this.Controls.Add(this.textBoxOPhone);
            this.Controls.Add(this.textBoxOName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.richTextBoxProblemDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WorkLogForm";
            this.Text = "WorkLogForm";
            this.Load += new System.EventHandler(this.WorkLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxProblemDesc;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxOName;
        private System.Windows.Forms.TextBox textBoxOPhone;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_CompleteTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLPlate;
    }
}