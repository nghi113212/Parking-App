using BUS;
using Word = Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_3_Layer_Model
{
    public partial class BillForm : Form
    {
        private int vehicleId;
        private int serviceId;
        private string parkingType;
        private DateTime timeIn;
        public BillForm(int vehicleId, int serviceId, string parkingType, DateTime timeIn)
        {
            InitializeComponent();
            this.vehicleId = vehicleId;
            this.serviceId = serviceId;
            this.parkingType = parkingType;
            this.timeIn = timeIn;
        }

        public BillForm(int vehicleId, int serviceId)
        {
            InitializeComponent();
            this.vehicleId = vehicleId;
            this.serviceId = serviceId;

        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            labelBillID.Text = "Bill Id: " + BillBUS.Instance.GetCurrentBillId(vehicleId, serviceId);
            labelVehicleId.Text = "Vehicle Id: " + vehicleId;
            labelService.Text = "Service: " + BillBUS.Instance.GetServiceName(serviceId);
            labelCustomerName.Text = "Customer Name: " + BillBUS.Instance.GetOwnerName(vehicleId);
            labelPrintDate.Text = "Print Date: " + DateTime.Now.ToString("dd/MM/yyyy");

            decimal price = (decimal)VehicleBUS.Instance.GetVehiclePrice(vehicleId);
            if (serviceId == 1)
            {
                decimal baseTotal = CalculateBill(timeIn, DateTime.Now, price, parkingType);
                decimal penalty = CalculatePenalty(timeIn, DateTime.Now, parkingType, price);
                decimal finalTotal = baseTotal + penalty;
                labelBaseTotal.Text = baseTotal.ToString("C");
                labelPenalty.Text = penalty.ToString("C");
                labelTotalCost.Text = finalTotal.ToString("C");
            }
            else if (serviceId == 2 || serviceId == 3)
            {
                labelBillID.Text = "Bill Id: " + BillBUS.Instance.GetCurrentBillId2(vehicleId, serviceId);
                decimal cost = (decimal)BillBUS.Instance.GetBillCost(vehicleId, serviceId);
                string note = BillBUS.Instance.GetBillNote(vehicleId, serviceId);

                labelBaseTotal.Text = cost.ToString("C");
                labelPenalty.Visible = false;
                labelTotalCost.Text = cost.ToString("C");

                labelNote.Text = "Note: " + note;
            }
        }

        private decimal CalculateBill(DateTime timeIn, DateTime timeOut, decimal price, string parkingType)
        {
            TimeSpan duration = timeOut - timeIn;
            double hours = duration.TotalHours;
            double days = duration.TotalDays;

            decimal total = 0;

            switch (parkingType.ToLower())
            {
                case "hour":
                    total = (decimal)Math.Ceiling(hours) * price;
                    //if (hours > 24)
                    //    total *= 2 * 8;
                    break;
                case "day":
                    total = price * 8;
                    //if (days > 1)
                    //    total *= 3;
                    break;
                case "week":
                    total = price * 8 * 3;
                    //if (days > 10 && days < 30)
                    //    total *= 2;
                    break;
                case "month":
                    total = price * 8 * 2 * 3;
                    break;
            }

            return total;
        }

        private decimal CalculatePenalty(DateTime timeIn, DateTime timeOut, string parkingType, decimal price)
        {
            TimeSpan duration = timeOut - timeIn;
            double hours = duration.TotalHours;
            double days = duration.TotalDays;

            decimal penalty = 0;

            switch (parkingType.ToLower())
            {
                case "hour":
                    if (hours > 24)
                        penalty = price * 8 * 2; // 2 ngày
                    break;
                case "day":
                    if (days > 1)
                        penalty = price * 8 * 3; // 1 tuần
                    break;
                case "week":
                    if (days > 10 && days < 30)
                        penalty = price * 8 * 2 * 3; // 1 tháng
                    break;
            }

            return penalty;
        }

        private void bt_Paid_Click(object sender, EventArgs e)
        {
            if (serviceId == 1)
            {
                string billId = BillBUS.Instance.GetCurrentBillId(vehicleId, serviceId);
                decimal cost = decimal.Parse(labelBaseTotal.Text.Replace("$", "").Replace(",", ""));
                decimal fine = decimal.Parse(labelPenalty.Text.Replace("$", "").Replace(",", ""));

                bool success = BillBUS.Instance.MarkBillAsPaid(billId, cost, fine);

                if (success)
                {
                    MessageBox.Show("Bill has been marked as paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VehicleBUS.Instance.DeleteVehicle(vehicleId);
                    VehicleBUS.Instance.GetAllVehicles();
                    this.Close(); // hoặc refresh lại form nếu bạn muốn
                }
                else
                {
                    MessageBox.Show("Failed to update the bill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (serviceId == 2 || serviceId == 3)
            {
                string billId = BillBUS.Instance.GetCurrentBillId2(vehicleId, serviceId);

                bool success = BillBUS.Instance.MarkBillAsPaid2(billId);

                if (success)
                {
                    MessageBox.Show("Bill has been marked as paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VehicleBUS.Instance.DeleteVehicle(vehicleId);
                    VehicleBUS.Instance.GetAllVehicles();
                    this.Close(); // hoặc refresh lại form nếu bạn muốn
                }
                else
                {
                    MessageBox.Show("Failed to update the bill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();

            wordApp.Visible = false;

            // Add title
            Word.Paragraph title = doc.Content.Paragraphs.Add();
            title.Range.Text = "BILL RECEIPT";
            title.Range.Font.Size = 18;
            title.Range.Font.Bold = 1;
            title.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.InsertParagraphAfter();

            // Add details
            void AddLine(string label, string value)
            {
                Word.Paragraph p = doc.Content.Paragraphs.Add();
                p.Range.Text = $"{label}: {value}";
                p.Range.Font.Size = 12;
                p.Range.Font.Bold = 0;
                p.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                p.Range.InsertParagraphAfter();
            }

            AddLine("Bill ID", BillBUS.Instance.GetCurrentBillId(vehicleId, serviceId));
            AddLine("Vehicle ID", vehicleId.ToString());
            AddLine("Service", BillBUS.Instance.GetServiceName(serviceId));
            AddLine("Customer Name", BillBUS.Instance.GetOwnerName(vehicleId));
            AddLine("Print Date", DateTime.Now.ToString("dd/MM/yyyy"));
            AddLine("Base Cost", labelBaseTotal.Text);
            AddLine("Penalty", labelPenalty.Text);
            AddLine("Total", labelTotalCost.Text);
            AddLine("Note", labelNote.Text.Replace("Note: ", ""));

            // Save file
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx",
                FileName = "Bill_" + vehicleId + ".docx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                doc.SaveAs2(sfd.FileName);
                MessageBox.Show("Exported successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cleanup
            doc.Close();
            wordApp.Quit();
        }
    }
}
