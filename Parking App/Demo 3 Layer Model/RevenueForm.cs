using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Demo_3_Layer_Model
{
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            DateTime fromDate, toDate;

            if (rbToday.Checked)
            {
                fromDate = DateTime.Today;
                toDate = DateTime.Today.AddDays(1).AddTicks(-1);

                dateTimePicker1.Value = fromDate;
                dateTimePicker2.Value = toDate;
            }
            else if (rbThisWeek.Checked)
            {
                int delta = DayOfWeek.Monday - DateTime.Today.DayOfWeek;
                fromDate = DateTime.Today.AddDays(delta);
                toDate = fromDate.AddDays(6);

                dateTimePicker1.Value = fromDate;
                dateTimePicker2.Value = toDate;
            }
            else if (rbThisMonth.Checked)
            {
                fromDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                toDate = fromDate.AddMonths(1).AddDays(-1);

                dateTimePicker1.Value = fromDate;
                dateTimePicker2.Value = toDate;

                dateTimePicker1.Value = fromDate;
                dateTimePicker2.Value = toDate;
            }
            else if (rbThisYear.Checked)
            {
                fromDate = new DateTime(DateTime.Today.Year, 1, 1);
                toDate = new DateTime(DateTime.Today.Year, 12, 31);

                dateTimePicker1.Value = fromDate;
                dateTimePicker2.Value = toDate;
            }
            else // Custom
            {
                fromDate = dateTimePicker1.Value.Date;
                toDate = dateTimePicker2.Value.Date;
            } 

            DataTable table = BillBUS.Instance.GetRevenue(fromDate, toDate);

            dataGridView1.DataSource = table;

            decimal total = table.AsEnumerable().Sum(row => row.Field<decimal>("cost"));
            lbTotalRevenue.Text = "Total Revenue: " + total.ToString("C");
        }

        private void bt_Export2Report_Click(object sender, EventArgs e)
        {
            ExportToWord(dataGridView1.DataSource as DataTable, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
        }

        private void ExportToWord(DataTable table, DateTime fromDate, DateTime toDate)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();

            // Tiêu đề
            Word.Paragraph title = doc.Content.Paragraphs.Add();
            title.Range.Text = "Revenue Report";
            title.Range.Font.Size = 20;
            title.Range.Font.Bold = 1;
            title.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.InsertParagraphAfter();

            // Ngày in báo cáo
            Word.Paragraph dateRange = doc.Content.Paragraphs.Add();
            dateRange.Range.Text = $"From: {fromDate:dd/MM/yyyy}    To: {toDate:dd/MM/yyyy}";
            dateRange.Range.Font.Size = 12;
            dateRange.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            dateRange.Range.InsertParagraphAfter();

            // Bảng dữ liệu
            Word.Paragraph tablePara = doc.Content.Paragraphs.Add();
            Word.Table wordTable = doc.Tables.Add(tablePara.Range, table.Rows.Count + 1, table.Columns.Count);
            wordTable.Borders.Enable = 1;

            // Header
            for (int c = 0; c < table.Columns.Count; c++)
            {
                wordTable.Cell(1, c + 1).Range.Text = table.Columns[c].ColumnName;
                wordTable.Cell(1, c + 1).Range.Bold = 1;
                wordTable.Cell(1, c + 1).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
            }

            // Data rows
            for (int r = 0; r < table.Rows.Count; r++)
            {
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    wordTable.Cell(r + 2, c + 1).Range.Text = table.Rows[r][c].ToString();
                }
            }

            // Tổng doanh thu (giả sử có cột "Total" kiểu số)
            decimal totalRevenue = table.AsEnumerable().Sum(row => row.Field<decimal>("cost"));
            Word.Paragraph summary = doc.Content.Paragraphs.Add();
            summary.Range.Text = $"\nTotal Revenue: {totalRevenue:C}";
            summary.Range.Font.Bold = 1;
            summary.Range.Font.Size = 14;
            summary.Range.InsertParagraphAfter();

            // Lưu file
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RevenueReport.docx");
            doc.SaveAs2(filePath);
            doc.Close();
            wordApp.Quit();

            MessageBox.Show("Exported to Word successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
