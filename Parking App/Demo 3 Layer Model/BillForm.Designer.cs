namespace Demo_3_Layer_Model
{
    partial class BillForm
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
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelBaseTotal = new System.Windows.Forms.Label();
            this.labelPenalty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBillID = new System.Windows.Forms.Label();
            this.labelVehicleId = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPrintDate = new System.Windows.Forms.Label();
            this.bt_Paid = new System.Windows.Forms.Button();
            this.bt_Print = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.ForeColor = System.Drawing.Color.Red;
            this.labelTotalCost.Location = new System.Drawing.Point(300, 369);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(96, 36);
            this.labelTotalCost.TabIndex = 0;
            this.labelTotalCost.Text = "$0.00";
            // 
            // labelBaseTotal
            // 
            this.labelBaseTotal.AutoSize = true;
            this.labelBaseTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaseTotal.Location = new System.Drawing.Point(301, 277);
            this.labelBaseTotal.Name = "labelBaseTotal";
            this.labelBaseTotal.Size = new System.Drawing.Size(66, 25);
            this.labelBaseTotal.TabIndex = 1;
            this.labelBaseTotal.Text = "$0.00";
            // 
            // labelPenalty
            // 
            this.labelPenalty.AutoSize = true;
            this.labelPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenalty.Location = new System.Drawing.Point(301, 325);
            this.labelPenalty.Name = "labelPenalty";
            this.labelPenalty.Size = new System.Drawing.Size(66, 25);
            this.labelPenalty.TabIndex = 2;
            this.labelPenalty.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill";
            // 
            // labelBillID
            // 
            this.labelBillID.AutoSize = true;
            this.labelBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillID.Location = new System.Drawing.Point(12, 73);
            this.labelBillID.Name = "labelBillID";
            this.labelBillID.Size = new System.Drawing.Size(75, 25);
            this.labelBillID.TabIndex = 4;
            this.labelBillID.Text = "Bill ID:";
            // 
            // labelVehicleId
            // 
            this.labelVehicleId.AutoSize = true;
            this.labelVehicleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleId.Location = new System.Drawing.Point(12, 120);
            this.labelVehicleId.Name = "labelVehicleId";
            this.labelVehicleId.Size = new System.Drawing.Size(121, 25);
            this.labelVehicleId.TabIndex = 5;
            this.labelVehicleId.Text = "Vehicle Id: ";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(12, 164);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(92, 25);
            this.labelService.TabIndex = 6;
            this.labelService.Text = "Service:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(12, 213);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(171, 25);
            this.labelCustomerName.TabIndex = 7;
            this.labelCustomerName.Text = "Customer name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fine:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(11, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total:";
            // 
            // labelPrintDate
            // 
            this.labelPrintDate.AutoSize = true;
            this.labelPrintDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrintDate.Location = new System.Drawing.Point(328, 73);
            this.labelPrintDate.Name = "labelPrintDate";
            this.labelPrintDate.Size = new System.Drawing.Size(111, 25);
            this.labelPrintDate.TabIndex = 11;
            this.labelPrintDate.Text = "Print date:";
            // 
            // bt_Paid
            // 
            this.bt_Paid.BackColor = System.Drawing.Color.Black;
            this.bt_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Paid.ForeColor = System.Drawing.Color.Lime;
            this.bt_Paid.Location = new System.Drawing.Point(437, 489);
            this.bt_Paid.Name = "bt_Paid";
            this.bt_Paid.Size = new System.Drawing.Size(130, 44);
            this.bt_Paid.TabIndex = 12;
            this.bt_Paid.Text = "Paid";
            this.bt_Paid.UseVisualStyleBackColor = false;
            this.bt_Paid.Click += new System.EventHandler(this.bt_Paid_Click);
            // 
            // bt_Print
            // 
            this.bt_Print.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Print.Location = new System.Drawing.Point(223, 489);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(130, 44);
            this.bt_Print.TabIndex = 12;
            this.bt_Print.Text = "Print";
            this.bt_Print.UseVisualStyleBackColor = false;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.Red;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(17, 489);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(112, 44);
            this.bt_Cancel.TabIndex = 12;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(328, 120);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(64, 25);
            this.labelNote.TabIndex = 13;
            this.labelNote.Text = "Note:";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 545);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.bt_Paid);
            this.Controls.Add(this.labelPrintDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelVehicleId);
            this.Controls.Add(this.labelBillID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPenalty);
            this.Controls.Add(this.labelBaseTotal);
            this.Controls.Add(this.labelTotalCost);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelBaseTotal;
        private System.Windows.Forms.Label labelPenalty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBillID;
        private System.Windows.Forms.Label labelVehicleId;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPrintDate;
        private System.Windows.Forms.Button bt_Paid;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label labelNote;
    }
}