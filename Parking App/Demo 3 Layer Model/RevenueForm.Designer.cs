namespace Demo_3_Layer_Model
{
    partial class RevenueForm
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
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.rbThisWeek = new System.Windows.Forms.RadioButton();
            this.rbThisMonth = new System.Windows.Forms.RadioButton();
            this.rbThisYear = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Load = new System.Windows.Forms.Button();
            this.bt_Export2Report = new System.Windows.Forms.Button();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(592, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbToday.Location = new System.Drawing.Point(24, 20);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(94, 29);
            this.rbToday.TabIndex = 1;
            this.rbToday.TabStop = true;
            this.rbToday.Text = "Today";
            this.rbToday.UseVisualStyleBackColor = true;
            // 
            // rbThisWeek
            // 
            this.rbThisWeek.AutoSize = true;
            this.rbThisWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThisWeek.Location = new System.Drawing.Point(186, 20);
            this.rbThisWeek.Name = "rbThisWeek";
            this.rbThisWeek.Size = new System.Drawing.Size(137, 29);
            this.rbThisWeek.TabIndex = 2;
            this.rbThisWeek.TabStop = true;
            this.rbThisWeek.Text = "This Week";
            this.rbThisWeek.UseVisualStyleBackColor = true;
            // 
            // rbThisMonth
            // 
            this.rbThisMonth.AutoSize = true;
            this.rbThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThisMonth.Location = new System.Drawing.Point(380, 20);
            this.rbThisMonth.Name = "rbThisMonth";
            this.rbThisMonth.Size = new System.Drawing.Size(141, 29);
            this.rbThisMonth.TabIndex = 3;
            this.rbThisMonth.TabStop = true;
            this.rbThisMonth.Text = "This Month";
            this.rbThisMonth.UseVisualStyleBackColor = true;
            // 
            // rbThisYear
            // 
            this.rbThisYear.AutoSize = true;
            this.rbThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThisYear.Location = new System.Drawing.Point(24, 55);
            this.rbThisYear.Name = "rbThisYear";
            this.rbThisYear.Size = new System.Drawing.Size(126, 29);
            this.rbThisYear.TabIndex = 4;
            this.rbThisYear.TabStop = true;
            this.rbThisYear.Text = "This Year";
            this.rbThisYear.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(186, 55);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(175, 29);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Custom Range";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.rbThisYear);
            this.groupBox1.Controls.Add(this.rbThisMonth);
            this.groupBox1.Controls.Add(this.rbThisWeek);
            this.groupBox1.Controls.Add(this.rbToday);
            this.groupBox1.Location = new System.Drawing.Point(13, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(408, 34);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(93, 329);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(408, 34);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter by:";
            // 
            // bt_Load
            // 
            this.bt_Load.BackColor = System.Drawing.Color.Pink;
            this.bt_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Load.Location = new System.Drawing.Point(18, 454);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(151, 53);
            this.bt_Load.TabIndex = 10;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = false;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // bt_Export2Report
            // 
            this.bt_Export2Report.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Export2Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Export2Report.Location = new System.Drawing.Point(966, 23);
            this.bt_Export2Report.Name = "bt_Export2Report";
            this.bt_Export2Report.Size = new System.Drawing.Size(215, 53);
            this.bt_Export2Report.TabIndex = 10;
            this.bt_Export2Report.Text = "Export to Report";
            this.bt_Export2Report.UseVisualStyleBackColor = false;
            this.bt_Export2Report.Click += new System.EventHandler(this.bt_Export2Report_Click);
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenue.ForeColor = System.Drawing.Color.Green;
            this.lbTotalRevenue.Location = new System.Drawing.Point(586, 527);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(210, 32);
            this.lbTotalRevenue.TabIndex = 9;
            this.lbTotalRevenue.Text = "Total revenue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "From";
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 832);
            this.Controls.Add(this.bt_Export2Report);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotalRevenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RevenueForm";
            this.Text = "RevenueForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbToday;
        private System.Windows.Forms.RadioButton rbThisWeek;
        private System.Windows.Forms.RadioButton rbThisMonth;
        private System.Windows.Forms.RadioButton rbThisYear;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.Button bt_Export2Report;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label label3;
    }
}