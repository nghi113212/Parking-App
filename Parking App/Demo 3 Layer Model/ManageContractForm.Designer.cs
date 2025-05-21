namespace Demo_3_Layer_Model
{
    partial class ManageContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageContractForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxContractType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_ExportToWord = new System.Windows.Forms.Button();
            this.textBoxVehicleId = new System.Windows.Forms.TextBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.bt_FilterByPending = new System.Windows.Forms.Button();
            this.bt_FilterByComplete = new System.Windows.Forms.Button();
            this.bt_AllContract = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contract Type:";
            // 
            // comboBoxContractType
            // 
            this.comboBoxContractType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContractType.FormattingEnabled = true;
            this.comboBoxContractType.Location = new System.Drawing.Point(186, 33);
            this.comboBoxContractType.Name = "comboBoxContractType";
            this.comboBoxContractType.Size = new System.Drawing.Size(336, 33);
            this.comboBoxContractType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start day:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "End day:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(186, 211);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(336, 30);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(186, 253);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(336, 30);
            this.textBoxPrice.TabIndex = 4;
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(12, 305);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(123, 42);
            this.bt_Add.TabIndex = 5;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.Gold;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(141, 305);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(123, 42);
            this.bt_Save.TabIndex = 5;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.Salmon;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.Location = new System.Drawing.Point(270, 305);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(123, 42);
            this.bt_Remove.TabIndex = 5;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Location = new System.Drawing.Point(399, 305);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(123, 42);
            this.bt_Clear.TabIndex = 5;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 447);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // bt_ExportToWord
            // 
            this.bt_ExportToWord.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_ExportToWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ExportToWord.Location = new System.Drawing.Point(982, 33);
            this.bt_ExportToWord.Name = "bt_ExportToWord";
            this.bt_ExportToWord.Size = new System.Drawing.Size(199, 46);
            this.bt_ExportToWord.TabIndex = 7;
            this.bt_ExportToWord.Text = "Export To Word";
            this.bt_ExportToWord.UseVisualStyleBackColor = false;
            this.bt_ExportToWord.Click += new System.EventHandler(this.bt_ExportToWord_Click);
            // 
            // textBoxVehicleId
            // 
            this.textBoxVehicleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleId.Location = new System.Drawing.Point(186, 77);
            this.textBoxVehicleId.Name = "textBoxVehicleId";
            this.textBoxVehicleId.Size = new System.Drawing.Size(336, 30);
            this.textBoxVehicleId.TabIndex = 4;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerId.Location = new System.Drawing.Point(186, 120);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(336, 30);
            this.textBoxCustomerId.TabIndex = 4;
            // 
            // bt_FilterByPending
            // 
            this.bt_FilterByPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_FilterByPending.Location = new System.Drawing.Point(1017, 249);
            this.bt_FilterByPending.Name = "bt_FilterByPending";
            this.bt_FilterByPending.Size = new System.Drawing.Size(164, 32);
            this.bt_FilterByPending.TabIndex = 8;
            this.bt_FilterByPending.Text = "In processing";
            this.bt_FilterByPending.UseVisualStyleBackColor = true;
            this.bt_FilterByPending.Click += new System.EventHandler(this.bt_FilterByPending_Click);
            // 
            // bt_FilterByComplete
            // 
            this.bt_FilterByComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_FilterByComplete.Location = new System.Drawing.Point(1017, 283);
            this.bt_FilterByComplete.Name = "bt_FilterByComplete";
            this.bt_FilterByComplete.Size = new System.Drawing.Size(164, 32);
            this.bt_FilterByComplete.TabIndex = 9;
            this.bt_FilterByComplete.Text = "In effect";
            this.bt_FilterByComplete.UseVisualStyleBackColor = true;
            this.bt_FilterByComplete.Click += new System.EventHandler(this.bt_FilterByComplete_Click);
            // 
            // bt_AllContract
            // 
            this.bt_AllContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AllContract.Location = new System.Drawing.Point(1017, 216);
            this.bt_AllContract.Name = "bt_AllContract";
            this.bt_AllContract.Size = new System.Drawing.Size(164, 32);
            this.bt_AllContract.TabIndex = 8;
            this.bt_AllContract.Text = "All contract";
            this.bt_AllContract.UseVisualStyleBackColor = true;
            this.bt_AllContract.Click += new System.EventHandler(this.bt_AllContract_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(870, 337);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(270, 30);
            this.textBoxSearch.TabIndex = 10;
            // 
            // bt_Search
            // 
            this.bt_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Search.BackgroundImage")));
            this.bt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Search.Location = new System.Drawing.Point(1146, 337);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(35, 30);
            this.bt_Search.TabIndex = 11;
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // ManageContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 832);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.bt_FilterByComplete);
            this.Controls.Add(this.bt_AllContract);
            this.Controls.Add(this.bt_FilterByPending);
            this.Controls.Add(this.bt_ExportToWord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.textBoxVehicleId);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxContractType);
            this.Controls.Add(this.label1);
            this.Name = "ManageContractForm";
            this.Text = "ManageContractForm";
            this.Load += new System.EventHandler(this.ManageContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxContractType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_ExportToWord;
        private System.Windows.Forms.TextBox textBoxVehicleId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Button bt_FilterByPending;
        private System.Windows.Forms.Button bt_FilterByComplete;
        private System.Windows.Forms.Button bt_AllContract;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button bt_Search;
    }
}