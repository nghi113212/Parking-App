namespace Demo_3_Layer_Model
{
    partial class AddUnusedCarForm
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
            this.textBoxVehicleID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bt_UploadPic2 = new System.Windows.Forms.Button();
            this.bt_UploadPic1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxChooseCarType = new System.Windows.Forms.ComboBox();
            this.textBoxCarBrand = new System.Windows.Forms.TextBox();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVehicleID
            // 
            this.textBoxVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleID.Location = new System.Drawing.Point(171, 211);
            this.textBoxVehicleID.Name = "textBoxVehicleID";
            this.textBoxVehicleID.Size = new System.Drawing.Size(200, 27);
            this.textBoxVehicleID.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 53;
            this.label14.Text = "Vehicle ID:";
            // 
            // bt_UploadPic2
            // 
            this.bt_UploadPic2.Location = new System.Drawing.Point(295, 165);
            this.bt_UploadPic2.Name = "bt_UploadPic2";
            this.bt_UploadPic2.Size = new System.Drawing.Size(208, 34);
            this.bt_UploadPic2.TabIndex = 52;
            this.bt_UploadPic2.Text = "Upload owner (or car brand)\r\n";
            this.bt_UploadPic2.UseVisualStyleBackColor = true;
            this.bt_UploadPic2.Click += new System.EventHandler(this.bt_UploadPic2_Click);
            // 
            // bt_UploadPic1
            // 
            this.bt_UploadPic1.Location = new System.Drawing.Point(56, 166);
            this.bt_UploadPic1.Name = "bt_UploadPic1";
            this.bt_UploadPic1.Size = new System.Drawing.Size(210, 34);
            this.bt_UploadPic1.TabIndex = 51;
            this.bt_UploadPic1.Text = "Upload image plate (or bike)";
            this.bt_UploadPic1.UseVisualStyleBackColor = true;
            this.bt_UploadPic1.Click += new System.EventHandler(this.bt_UploadPic1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(293, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(56, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 342);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // comboBoxChooseCarType
            // 
            this.comboBoxChooseCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseCarType.FormattingEnabled = true;
            this.comboBoxChooseCarType.Location = new System.Drawing.Point(171, 379);
            this.comboBoxChooseCarType.Name = "comboBoxChooseCarType";
            this.comboBoxChooseCarType.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseCarType.TabIndex = 45;
            // 
            // textBoxCarBrand
            // 
            this.textBoxCarBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarBrand.Location = new System.Drawing.Point(171, 297);
            this.textBoxCarBrand.Name = "textBoxCarBrand";
            this.textBoxCarBrand.Size = new System.Drawing.Size(200, 27);
            this.textBoxCarBrand.TabIndex = 44;
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicensePlate.Location = new System.Drawing.Point(171, 254);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.Size = new System.Drawing.Size(200, 27);
            this.textBoxLicensePlate.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Time in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Car brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "License Plate:";
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(410, 358);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(110, 49);
            this.bt_Add.TabIndex = 55;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // AddUnusedCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 454);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.textBoxVehicleID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bt_UploadPic2);
            this.Controls.Add(this.bt_UploadPic1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxChooseCarType);
            this.Controls.Add(this.textBoxCarBrand);
            this.Controls.Add(this.textBoxLicensePlate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUnusedCarForm";
            this.Text = "AddUnusedCarForm";
            this.Load += new System.EventHandler(this.AddUnusedCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVehicleID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt_UploadPic2;
        private System.Windows.Forms.Button bt_UploadPic1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxChooseCarType;
        private System.Windows.Forms.TextBox textBoxCarBrand;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Add;
    }
}