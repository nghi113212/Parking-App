namespace Demo_3_Layer_Model
{
    partial class ManageVehicleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageVehicleForm));
            this.bt_AddVehicle = new System.Windows.Forms.Button();
            this.bt_RemoveVehicle = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.textBoxCarBrand = new System.Windows.Forms.TextBox();
            this.comboBoxChooseCarType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_UploadPic1 = new System.Windows.Forms.Button();
            this.bt_UploadPic2 = new System.Windows.Forms.Button();
            this.radioButtonParkingService = new System.Windows.Forms.RadioButton();
            this.radioButtonWashingService = new System.Windows.Forms.RadioButton();
            this.radioButtonFixingService = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxChooseAvailablePosition = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPCardCode = new System.Windows.Forms.TextBox();
            this.textBoxCarOwnerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCarOwnerPhone = new System.Windows.Forms.TextBox();
            this.richTextBoxCarIssueDesc = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carParkingDBDataSet = new Demo_3_Layer_Model.CarParkingDBDataSet();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxVehicleID = new System.Windows.Forms.TextBox();
            this.bt_SearchVehicle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vehicleTableAdapter = new Demo_3_Layer_Model.CarParkingDBDataSetTableAdapters.VehicleTableAdapter();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonHour = new System.Windows.Forms.RadioButton();
            this.radioButton_Other = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_AddVehicle
            // 
            this.bt_AddVehicle.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_AddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddVehicle.Location = new System.Drawing.Point(17, 427);
            this.bt_AddVehicle.Name = "bt_AddVehicle";
            this.bt_AddVehicle.Size = new System.Drawing.Size(75, 43);
            this.bt_AddVehicle.TabIndex = 0;
            this.bt_AddVehicle.Text = "Add";
            this.bt_AddVehicle.UseVisualStyleBackColor = false;
            this.bt_AddVehicle.Click += new System.EventHandler(this.bt_AddVehicle_Click);
            // 
            // bt_RemoveVehicle
            // 
            this.bt_RemoveVehicle.BackColor = System.Drawing.Color.Salmon;
            this.bt_RemoveVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RemoveVehicle.Location = new System.Drawing.Point(181, 427);
            this.bt_RemoveVehicle.Name = "bt_RemoveVehicle";
            this.bt_RemoveVehicle.Size = new System.Drawing.Size(85, 43);
            this.bt_RemoveVehicle.TabIndex = 2;
            this.bt_RemoveVehicle.Text = "Remove";
            this.bt_RemoveVehicle.UseVisualStyleBackColor = false;
            this.bt_RemoveVehicle.Click += new System.EventHandler(this.bt_RemoveVehicle_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.Gold;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(98, 427);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(77, 43);
            this.bt_Save.TabIndex = 3;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.Location = new System.Drawing.Point(272, 427);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(85, 43);
            this.bt_Refresh.TabIndex = 4;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(363, 427);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 43);
            this.bt_Cancel.TabIndex = 5;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "License Plate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Car brand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time in:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type:";
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicensePlate.Location = new System.Drawing.Point(162, 111);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.Size = new System.Drawing.Size(200, 27);
            this.textBoxLicensePlate.TabIndex = 11;
            // 
            // textBoxCarBrand
            // 
            this.textBoxCarBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarBrand.Location = new System.Drawing.Point(162, 154);
            this.textBoxCarBrand.Name = "textBoxCarBrand";
            this.textBoxCarBrand.Size = new System.Drawing.Size(200, 27);
            this.textBoxCarBrand.TabIndex = 12;
            // 
            // comboBoxChooseCarType
            // 
            this.comboBoxChooseCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseCarType.FormattingEnabled = true;
            this.comboBoxChooseCarType.Location = new System.Drawing.Point(162, 236);
            this.comboBoxChooseCarType.Name = "comboBoxChooseCarType";
            this.comboBoxChooseCarType.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseCarType.TabIndex = 14;
            this.comboBoxChooseCarType.SelectedValueChanged += new System.EventHandler(this.comboBoxChooseCarType_SelectedValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Image 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(676, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Image 2:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(420, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(680, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(959, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Choose service:";
            // 
            // bt_UploadPic1
            // 
            this.bt_UploadPic1.Location = new System.Drawing.Point(420, 230);
            this.bt_UploadPic1.Name = "bt_UploadPic1";
            this.bt_UploadPic1.Size = new System.Drawing.Size(210, 34);
            this.bt_UploadPic1.TabIndex = 21;
            this.bt_UploadPic1.Text = "Upload image plate (or bike)";
            this.bt_UploadPic1.UseVisualStyleBackColor = true;
            this.bt_UploadPic1.Click += new System.EventHandler(this.bt_UploadPic1_Click);
            // 
            // bt_UploadPic2
            // 
            this.bt_UploadPic2.Location = new System.Drawing.Point(682, 230);
            this.bt_UploadPic2.Name = "bt_UploadPic2";
            this.bt_UploadPic2.Size = new System.Drawing.Size(208, 34);
            this.bt_UploadPic2.TabIndex = 22;
            this.bt_UploadPic2.Text = "Upload owner (or car brand)\r\n";
            this.bt_UploadPic2.UseVisualStyleBackColor = true;
            this.bt_UploadPic2.Click += new System.EventHandler(this.bt_UploadPic2_Click);
            // 
            // radioButtonParkingService
            // 
            this.radioButtonParkingService.AutoSize = true;
            this.radioButtonParkingService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonParkingService.ForeColor = System.Drawing.Color.Red;
            this.radioButtonParkingService.Location = new System.Drawing.Point(964, 71);
            this.radioButtonParkingService.Name = "radioButtonParkingService";
            this.radioButtonParkingService.Size = new System.Drawing.Size(93, 24);
            this.radioButtonParkingService.TabIndex = 23;
            this.radioButtonParkingService.TabStop = true;
            this.radioButtonParkingService.Text = "Parking";
            this.radioButtonParkingService.UseVisualStyleBackColor = true;
            this.radioButtonParkingService.CheckedChanged += new System.EventHandler(this.radioButtonParkingService_CheckedChanged);
            // 
            // radioButtonWashingService
            // 
            this.radioButtonWashingService.AutoSize = true;
            this.radioButtonWashingService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWashingService.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonWashingService.Location = new System.Drawing.Point(964, 114);
            this.radioButtonWashingService.Name = "radioButtonWashingService";
            this.radioButtonWashingService.Size = new System.Drawing.Size(102, 24);
            this.radioButtonWashingService.TabIndex = 24;
            this.radioButtonWashingService.TabStop = true;
            this.radioButtonWashingService.Text = "Washing";
            this.radioButtonWashingService.UseVisualStyleBackColor = true;
            this.radioButtonWashingService.CheckedChanged += new System.EventHandler(this.radioButtonWashingService_CheckedChanged);
            // 
            // radioButtonFixingService
            // 
            this.radioButtonFixingService.AutoSize = true;
            this.radioButtonFixingService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFixingService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButtonFixingService.Location = new System.Drawing.Point(964, 157);
            this.radioButtonFixingService.Name = "radioButtonFixingService";
            this.radioButtonFixingService.Size = new System.Drawing.Size(80, 24);
            this.radioButtonFixingService.TabIndex = 25;
            this.radioButtonFixingService.TabStop = true;
            this.radioButtonFixingService.Text = "Fixing";
            this.radioButtonFixingService.UseVisualStyleBackColor = true;
            this.radioButtonFixingService.CheckedChanged += new System.EventHandler(this.radioButtonFixingService_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(378, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Owner name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Position:";
            // 
            // comboBoxChooseAvailablePosition
            // 
            this.comboBoxChooseAvailablePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseAvailablePosition.FormattingEnabled = true;
            this.comboBoxChooseAvailablePosition.Location = new System.Drawing.Point(176, 311);
            this.comboBoxChooseAvailablePosition.Name = "comboBoxChooseAvailablePosition";
            this.comboBoxChooseAvailablePosition.Size = new System.Drawing.Size(152, 28);
            this.comboBoxChooseAvailablePosition.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Parking card code:";
            // 
            // textBoxPCardCode
            // 
            this.textBoxPCardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPCardCode.Location = new System.Drawing.Point(227, 349);
            this.textBoxPCardCode.Name = "textBoxPCardCode";
            this.textBoxPCardCode.Size = new System.Drawing.Size(101, 30);
            this.textBoxPCardCode.TabIndex = 30;
            // 
            // textBoxCarOwnerName
            // 
            this.textBoxCarOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarOwnerName.Location = new System.Drawing.Point(525, 325);
            this.textBoxCarOwnerName.Name = "textBoxCarOwnerName";
            this.textBoxCarOwnerName.Size = new System.Drawing.Size(230, 30);
            this.textBoxCarOwnerName.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(378, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Phone:";
            // 
            // textBoxCarOwnerPhone
            // 
            this.textBoxCarOwnerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarOwnerPhone.Location = new System.Drawing.Point(525, 363);
            this.textBoxCarOwnerPhone.Name = "textBoxCarOwnerPhone";
            this.textBoxCarOwnerPhone.Size = new System.Drawing.Size(230, 30);
            this.textBoxCarOwnerPhone.TabIndex = 33;
            // 
            // richTextBoxCarIssueDesc
            // 
            this.richTextBoxCarIssueDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCarIssueDesc.Location = new System.Drawing.Point(778, 316);
            this.richTextBoxCarIssueDesc.Name = "richTextBoxCarIssueDesc";
            this.richTextBoxCarIssueDesc.Size = new System.Drawing.Size(403, 87);
            this.richTextBoxCarIssueDesc.TabIndex = 34;
            this.richTextBoxCarIssueDesc.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(773, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "Problem description:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 482);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 338);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.carParkingDBDataSet;
            // 
            // carParkingDBDataSet
            // 
            this.carParkingDBDataSet.DataSetName = "CarParkingDBDataSet";
            this.carParkingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Vehicle ID:";
            // 
            // textBoxVehicleID
            // 
            this.textBoxVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleID.Location = new System.Drawing.Point(162, 68);
            this.textBoxVehicleID.Name = "textBoxVehicleID";
            this.textBoxVehicleID.Size = new System.Drawing.Size(200, 27);
            this.textBoxVehicleID.TabIndex = 38;
            // 
            // bt_SearchVehicle
            // 
            this.bt_SearchVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_SearchVehicle.BackgroundImage")));
            this.bt_SearchVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_SearchVehicle.Location = new System.Drawing.Point(1140, 432);
            this.bt_SearchVehicle.Name = "bt_SearchVehicle";
            this.bt_SearchVehicle.Size = new System.Drawing.Size(41, 43);
            this.bt_SearchVehicle.TabIndex = 39;
            this.bt_SearchVehicle.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(778, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 34);
            this.textBox1.TabIndex = 40;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDay.ForeColor = System.Drawing.Color.Red;
            this.radioButtonDay.Location = new System.Drawing.Point(105, 12);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(63, 24);
            this.radioButtonDay.TabIndex = 41;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Day";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeek
            // 
            this.radioButtonWeek.AutoSize = true;
            this.radioButtonWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeek.ForeColor = System.Drawing.Color.Red;
            this.radioButtonWeek.Location = new System.Drawing.Point(183, 12);
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.radioButtonWeek.Size = new System.Drawing.Size(76, 24);
            this.radioButtonWeek.TabIndex = 42;
            this.radioButtonWeek.TabStop = true;
            this.radioButtonWeek.Text = "Week";
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMonth.ForeColor = System.Drawing.Color.Red;
            this.radioButtonMonth.Location = new System.Drawing.Point(274, 12);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(81, 24);
            this.radioButtonMonth.TabIndex = 43;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "Month";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHour);
            this.groupBox1.Controls.Add(this.radioButtonMonth);
            this.groupBox1.Controls.Add(this.radioButtonWeek);
            this.groupBox1.Controls.Add(this.radioButtonDay);
            this.groupBox1.Location = new System.Drawing.Point(7, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 42);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonHour
            // 
            this.radioButtonHour.AutoSize = true;
            this.radioButtonHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHour.ForeColor = System.Drawing.Color.Red;
            this.radioButtonHour.Location = new System.Drawing.Point(6, 12);
            this.radioButtonHour.Name = "radioButtonHour";
            this.radioButtonHour.Size = new System.Drawing.Size(71, 24);
            this.radioButtonHour.TabIndex = 44;
            this.radioButtonHour.TabStop = true;
            this.radioButtonHour.Text = "Hour";
            this.radioButtonHour.UseVisualStyleBackColor = true;
            // 
            // radioButton_Other
            // 
            this.radioButton_Other.AutoSize = true;
            this.radioButton_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Other.ForeColor = System.Drawing.Color.SaddleBrown;
            this.radioButton_Other.Location = new System.Drawing.Point(964, 201);
            this.radioButton_Other.Name = "radioButton_Other";
            this.radioButton_Other.Size = new System.Drawing.Size(97, 24);
            this.radioButton_Other.TabIndex = 25;
            this.radioButton_Other.TabStop = true;
            this.radioButton_Other.Text = "For rent";
            this.radioButton_Other.UseVisualStyleBackColor = true;
            this.radioButton_Other.CheckedChanged += new System.EventHandler(this.radioButton_Other_CheckedChanged);
            // 
            // ManageVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 832);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_SearchVehicle);
            this.Controls.Add(this.textBoxVehicleID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.richTextBoxCarIssueDesc);
            this.Controls.Add(this.textBoxCarOwnerPhone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxCarOwnerName);
            this.Controls.Add(this.textBoxPCardCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxChooseAvailablePosition);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton_Other);
            this.Controls.Add(this.radioButtonFixingService);
            this.Controls.Add(this.radioButtonWashingService);
            this.Controls.Add(this.radioButtonParkingService);
            this.Controls.Add(this.bt_UploadPic2);
            this.Controls.Add(this.bt_UploadPic1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxChooseCarType);
            this.Controls.Add(this.textBoxCarBrand);
            this.Controls.Add(this.textBoxLicensePlate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_RemoveVehicle);
            this.Controls.Add(this.bt_AddVehicle);
            this.Name = "ManageVehicleForm";
            this.Text = "ManageVehicleForm";
            this.Load += new System.EventHandler(this.ManageVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AddVehicle;
        private System.Windows.Forms.Button bt_RemoveVehicle;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.TextBox textBoxCarBrand;
        private System.Windows.Forms.ComboBox comboBoxChooseCarType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_UploadPic1;
        private System.Windows.Forms.Button bt_UploadPic2;
        private System.Windows.Forms.RadioButton radioButtonParkingService;
        private System.Windows.Forms.RadioButton radioButtonWashingService;
        private System.Windows.Forms.RadioButton radioButtonFixingService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxChooseAvailablePosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPCardCode;
        private System.Windows.Forms.TextBox textBoxCarOwnerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCarOwnerPhone;
        private System.Windows.Forms.RichTextBox richTextBoxCarIssueDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxVehicleID;
        private System.Windows.Forms.Button bt_SearchVehicle;
        private System.Windows.Forms.TextBox textBox1;
        private CarParkingDBDataSet carParkingDBDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private CarParkingDBDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonHour;
        private System.Windows.Forms.RadioButton radioButton_Other;
    }
}