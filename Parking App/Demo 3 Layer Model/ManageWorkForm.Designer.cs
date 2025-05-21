namespace Demo_3_Layer_Model
{
    partial class ManageWorkForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMorning = new System.Windows.Forms.RadioButton();
            this.radioButtonAfternoon = new System.Windows.Forms.RadioButton();
            this.radioButtonEverning = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEverning = new System.Windows.Forms.Button();
            this.buttonAfternoon = new System.Windows.Forms.Button();
            this.buttonMorning = new System.Windows.Forms.Button();
            this.bt_Salary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(703, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 366);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(520, 454);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(661, 366);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "End time:";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(229, 74);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(415, 34);
            this.textBoxEmployeeID.TabIndex = 3;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.Location = new System.Drawing.Point(520, 345);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(126, 46);
            this.bt_Refresh.TabIndex = 14;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = true;
            // 
            // bt_Clear
            // 
            this.bt_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Location = new System.Drawing.Point(415, 345);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(100, 46);
            this.bt_Clear.TabIndex = 15;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.Salmon;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.Location = new System.Drawing.Point(290, 345);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(119, 46);
            this.bt_Remove.TabIndex = 11;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(18, 345);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(130, 46);
            this.bt_Add.TabIndex = 12;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.Gold;
            this.bt_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.Location = new System.Drawing.Point(154, 345);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(130, 46);
            this.bt_Edit.TabIndex = 13;
            this.bt_Edit.Text = "Save";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(415, 34);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(229, 214);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(415, 34);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // radioButtonMorning
            // 
            this.radioButtonMorning.AutoSize = true;
            this.radioButtonMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMorning.Location = new System.Drawing.Point(6, 17);
            this.radioButtonMorning.Name = "radioButtonMorning";
            this.radioButtonMorning.Size = new System.Drawing.Size(129, 33);
            this.radioButtonMorning.TabIndex = 17;
            this.radioButtonMorning.TabStop = true;
            this.radioButtonMorning.Text = "Morning";
            this.radioButtonMorning.UseVisualStyleBackColor = true;
            this.radioButtonMorning.CheckedChanged += new System.EventHandler(this.radioButtonMorning_CheckedChanged);
            // 
            // radioButtonAfternoon
            // 
            this.radioButtonAfternoon.AutoSize = true;
            this.radioButtonAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAfternoon.Location = new System.Drawing.Point(175, 17);
            this.radioButtonAfternoon.Name = "radioButtonAfternoon";
            this.radioButtonAfternoon.Size = new System.Drawing.Size(146, 33);
            this.radioButtonAfternoon.TabIndex = 17;
            this.radioButtonAfternoon.TabStop = true;
            this.radioButtonAfternoon.Text = "Afternoon";
            this.radioButtonAfternoon.UseVisualStyleBackColor = true;
            this.radioButtonAfternoon.CheckedChanged += new System.EventHandler(this.radioButtonAfternoon_CheckedChanged);
            // 
            // radioButtonEverning
            // 
            this.radioButtonEverning.AutoSize = true;
            this.radioButtonEverning.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEverning.Location = new System.Drawing.Point(347, 17);
            this.radioButtonEverning.Name = "radioButtonEverning";
            this.radioButtonEverning.Size = new System.Drawing.Size(137, 33);
            this.radioButtonEverning.TabIndex = 17;
            this.radioButtonEverning.TabStop = true;
            this.radioButtonEverning.Text = "Everning";
            this.radioButtonEverning.UseVisualStyleBackColor = true;
            this.radioButtonEverning.CheckedChanged += new System.EventHandler(this.radioButtonEverning_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAfternoon);
            this.groupBox1.Controls.Add(this.radioButtonEverning);
            this.groupBox1.Controls.Add(this.radioButtonMorning);
            this.groupBox1.Location = new System.Drawing.Point(154, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 56);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // buttonEverning
            // 
            this.buttonEverning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEverning.Location = new System.Drawing.Point(355, 558);
            this.buttonEverning.Name = "buttonEverning";
            this.buttonEverning.Size = new System.Drawing.Size(159, 46);
            this.buttonEverning.TabIndex = 14;
            this.buttonEverning.Text = "Everning";
            this.buttonEverning.UseVisualStyleBackColor = true;
            this.buttonEverning.Click += new System.EventHandler(this.buttonEverning_Click);
            // 
            // buttonAfternoon
            // 
            this.buttonAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfternoon.Location = new System.Drawing.Point(355, 506);
            this.buttonAfternoon.Name = "buttonAfternoon";
            this.buttonAfternoon.Size = new System.Drawing.Size(159, 46);
            this.buttonAfternoon.TabIndex = 14;
            this.buttonAfternoon.Text = "Afternoon";
            this.buttonAfternoon.UseVisualStyleBackColor = true;
            this.buttonAfternoon.Click += new System.EventHandler(this.buttonAfternoon_Click);
            // 
            // buttonMorning
            // 
            this.buttonMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMorning.Location = new System.Drawing.Point(355, 454);
            this.buttonMorning.Name = "buttonMorning";
            this.buttonMorning.Size = new System.Drawing.Size(160, 46);
            this.buttonMorning.TabIndex = 14;
            this.buttonMorning.Text = "Morning";
            this.buttonMorning.UseVisualStyleBackColor = true;
            this.buttonMorning.Click += new System.EventHandler(this.buttonMorning_Click);
            // 
            // bt_Salary
            // 
            this.bt_Salary.BackColor = System.Drawing.Color.Cyan;
            this.bt_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Salary.Location = new System.Drawing.Point(355, 610);
            this.bt_Salary.Name = "bt_Salary";
            this.bt_Salary.Size = new System.Drawing.Size(160, 49);
            this.bt_Salary.TabIndex = 19;
            this.bt_Salary.Text = "Today Salary";
            this.bt_Salary.UseVisualStyleBackColor = false;
            this.bt_Salary.Click += new System.EventHandler(this.bt_Salary_Click);
            // 
            // ManageWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 832);
            this.Controls.Add(this.bt_Salary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAfternoon);
            this.Controls.Add(this.buttonEverning);
            this.Controls.Add(this.buttonMorning);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageWorkForm";
            this.Text = "ManageWorkForm";
            this.Load += new System.EventHandler(this.ManageWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton radioButtonMorning;
        private System.Windows.Forms.RadioButton radioButtonAfternoon;
        private System.Windows.Forms.RadioButton radioButtonEverning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEverning;
        private System.Windows.Forms.Button buttonAfternoon;
        private System.Windows.Forms.Button buttonMorning;
        private System.Windows.Forms.Button bt_Salary;
    }
}