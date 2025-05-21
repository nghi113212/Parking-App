namespace Demo_3_Layer_Model
{
    partial class PositionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPositionID = new System.Windows.Forms.TextBox();
            this.textBoxPositionNumber = new System.Windows.Forms.TextBox();
            this.comboBoxPositionFor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_AddPosition = new System.Windows.Forms.Button();
            this.bt_SavePosition = new System.Windows.Forms.Button();
            this.bt_RemovePosition = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_ApplyNewPrice = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position for:";
            // 
            // textBoxPositionID
            // 
            this.textBoxPositionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPositionID.Location = new System.Drawing.Point(213, 112);
            this.textBoxPositionID.Name = "textBoxPositionID";
            this.textBoxPositionID.Size = new System.Drawing.Size(323, 30);
            this.textBoxPositionID.TabIndex = 3;
            // 
            // textBoxPositionNumber
            // 
            this.textBoxPositionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPositionNumber.Location = new System.Drawing.Point(213, 155);
            this.textBoxPositionNumber.Name = "textBoxPositionNumber";
            this.textBoxPositionNumber.Size = new System.Drawing.Size(323, 30);
            this.textBoxPositionNumber.TabIndex = 4;
            // 
            // comboBoxPositionFor
            // 
            this.comboBoxPositionFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPositionFor.FormattingEnabled = true;
            this.comboBoxPositionFor.Location = new System.Drawing.Point(213, 200);
            this.comboBoxPositionFor.Name = "comboBoxPositionFor";
            this.comboBoxPositionFor.Size = new System.Drawing.Size(323, 33);
            this.comboBoxPositionFor.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 515);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bt_AddPosition
            // 
            this.bt_AddPosition.BackColor = System.Drawing.Color.LightGreen;
            this.bt_AddPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddPosition.Location = new System.Drawing.Point(12, 248);
            this.bt_AddPosition.Name = "bt_AddPosition";
            this.bt_AddPosition.Size = new System.Drawing.Size(114, 40);
            this.bt_AddPosition.TabIndex = 7;
            this.bt_AddPosition.Text = "Add";
            this.bt_AddPosition.UseVisualStyleBackColor = false;
            this.bt_AddPosition.Click += new System.EventHandler(this.bt_AddPosition_Click);
            // 
            // bt_SavePosition
            // 
            this.bt_SavePosition.BackColor = System.Drawing.Color.Gold;
            this.bt_SavePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SavePosition.Location = new System.Drawing.Point(141, 248);
            this.bt_SavePosition.Name = "bt_SavePosition";
            this.bt_SavePosition.Size = new System.Drawing.Size(114, 40);
            this.bt_SavePosition.TabIndex = 8;
            this.bt_SavePosition.Text = "Save";
            this.bt_SavePosition.UseVisualStyleBackColor = false;
            this.bt_SavePosition.Click += new System.EventHandler(this.bt_SavePosition_Click);
            // 
            // bt_RemovePosition
            // 
            this.bt_RemovePosition.BackColor = System.Drawing.Color.LightCoral;
            this.bt_RemovePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RemovePosition.Location = new System.Drawing.Point(281, 248);
            this.bt_RemovePosition.Name = "bt_RemovePosition";
            this.bt_RemovePosition.Size = new System.Drawing.Size(114, 40);
            this.bt_RemovePosition.TabIndex = 9;
            this.bt_RemovePosition.Text = "Remove";
            this.bt_RemovePosition.UseVisualStyleBackColor = false;
            this.bt_RemovePosition.Click += new System.EventHandler(this.bt_RemovePosition_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Location = new System.Drawing.Point(422, 250);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(114, 40);
            this.bt_Clear.TabIndex = 10;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(594, 114);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(587, 176);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(554, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 832);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bt_ApplyNewPrice
            // 
            this.bt_ApplyNewPrice.BackColor = System.Drawing.Color.Gold;
            this.bt_ApplyNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ApplyNewPrice.ForeColor = System.Drawing.Color.Black;
            this.bt_ApplyNewPrice.Location = new System.Drawing.Point(1039, 335);
            this.bt_ApplyNewPrice.Name = "bt_ApplyNewPrice";
            this.bt_ApplyNewPrice.Size = new System.Drawing.Size(142, 85);
            this.bt_ApplyNewPrice.TabIndex = 15;
            this.bt_ApplyNewPrice.Text = "Apply new price";
            this.bt_ApplyNewPrice.UseVisualStyleBackColor = false;
            this.bt_ApplyNewPrice.Click += new System.EventHandler(this.bt_ApplyNewPrice_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(747, 329);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(89, 38);
            this.textBoxId.TabIndex = 16;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(747, 384);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(261, 38);
            this.textBoxPrice.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Price:";
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 832);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.bt_ApplyNewPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_RemovePosition);
            this.Controls.Add(this.bt_SavePosition);
            this.Controls.Add(this.bt_AddPosition);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxPositionFor);
            this.Controls.Add(this.textBoxPositionNumber);
            this.Controls.Add(this.textBoxPositionID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PositionForm";
            this.Text = "PositionForm";
            this.Load += new System.EventHandler(this.PositionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPositionID;
        private System.Windows.Forms.TextBox textBoxPositionNumber;
        private System.Windows.Forms.ComboBox comboBoxPositionFor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_AddPosition;
        private System.Windows.Forms.Button bt_SavePosition;
        private System.Windows.Forms.Button bt_RemovePosition;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_ApplyNewPrice;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}