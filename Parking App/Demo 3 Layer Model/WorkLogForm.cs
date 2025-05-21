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

namespace Demo_3_Layer_Model
{
    public partial class WorkLogForm : Form
    {
        public WorkLogForm()
        {
            InitializeComponent();
        }

        private void WorkLogForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VehicleBUS.Instance.GetVehiclesForTechnician();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // để tránh header
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxID.Text = row.Cells["vehicleId"].Value.ToString();
                textBoxOName.Text = row.Cells["ownerName"].Value.ToString();
                textBoxOPhone.Text = row.Cells["ownerPhone"].Value.ToString();
                textBoxLPlate.Text = row.Cells["licensePlate"].Value.ToString();

                string serviceName = row.Cells["serviceName"].Value.ToString();
                if (serviceName == "Sửa xe")
                {
                    // Nếu đã JOIN hoặc SELECT problem_desc trong câu SQL
                    richTextBoxProblemDesc.Text = row.Cells["problem_desc"].Value?.ToString() ?? "";
                }
                else
                {
                    richTextBoxProblemDesc.Clear();
                }
            }
        }

        private void bt_CompleteTask_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxID.Text, out int vehicleId))
            {
                if (double.TryParse(textBoxCost.Text, out double cost))
                {
                    string note = richTextBoxNote.Text;

                    bool success = BillBUS.Instance.CompleteBill(vehicleId, cost, note);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật hóa đơn thành công!");
                        dataGridView1.DataSource = VehicleBUS.Instance.GetVehiclesForTechnician();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn phù hợp để cập nhật.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập chi phí hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Xe không hợp lệ!");
            }
        }
        private void ClearInputFields()
        {
            textBoxID.Clear();
            textBoxOName.Clear();
            textBoxOPhone.Clear();
            textBoxLPlate.Clear();
            richTextBoxProblemDesc.Clear();
            textBoxCost.Clear();       // nếu bạn có thêm textbox nhập cost
            richTextBoxNote.Clear();       // nếu có textbox nhập ghi chú
        }
    }
}
