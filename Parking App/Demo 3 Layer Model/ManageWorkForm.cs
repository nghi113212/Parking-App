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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Demo_3_Layer_Model
{
    public partial class ManageWorkForm : Form
    {
        public ManageWorkForm()
        {
            InitializeComponent();
        }
        private void ManageWorkForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBUS.Instance.GetBasicEmployeeInfo();
            dataGridView2.DataSource = WorkSessionBUS.Instance.GetAllWorkSessionsWithRole();
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(textBoxEmployeeID.Text);
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;

            if (start >= end)
            {
                MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu");
                return;
            }

            //bool result = WorkSessionBUS.Instance.AssignSession(employeeId, start, end);
            //if (result)
            //    MessageBox.Show("Phân ca thành công!");
            //else
            //    MessageBox.Show("Phân ca thất bại!");

            // Lấy role của nhân viên đó
            string role = EmployeeBUS.Instance.GetRoleById(employeeId);

            if (WorkSessionBUS.Instance.IsShiftFull(start, end, role))
            {
                MessageBox.Show("Ca làm này đã đủ người cho vai trò " + role, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm vào nếu chưa đủ người
            WorkSessionBUS.Instance.AssignSession(employeeId, start, end);
            MessageBox.Show("Phân ca thành công!");
            dataGridView2.DataSource = WorkSessionBUS.Instance.GetAllWorkSessions(); // Cập nhật lại DataGridView
        }

        private void radioButtonMorning_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(1).AddHours(7);  // 7:00 AM
            dateTimePicker2.Value = DateTime.Today.AddDays(1).AddHours(11);
        }

        private void radioButtonAfternoon_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(1).AddHours(13);  // 7:00 AM
            dateTimePicker2.Value = DateTime.Today.AddDays(1).AddHours(17);
        }

        private void radioButtonEverning_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(1).AddHours(18);  // 7:00 AM
            dateTimePicker2.Value = DateTime.Today.AddDays(1).AddHours(22);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không phải header
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string employeeId = row.Cells["employeeId"].Value.ToString(); // hoặc dùng chỉ số cột: row.Cells[0]
                textBoxEmployeeID.Text = employeeId;
            }
        }

        int sessionId; // Biến toàn cục để lưu sessionId
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                sessionId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["sessionId"].Value);
                // Giả sử cột theo thứ tự: sessionId, employeeId, startTime, endTime
                textBoxEmployeeID.Text = (row.Cells["employeeId"].Value).ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["startTime"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["endTime"].Value);
            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các control trên form
                
                int employeeId = Convert.ToInt32(textBoxEmployeeID.Text);
                DateTime startTime = dateTimePicker1.Value;
                DateTime endTime = dateTimePicker2.Value;

                // Kiểm tra xem có phải giờ bắt đầu nhỏ hơn giờ kết thúc không
                if (startTime >= endTime)
                {
                    MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi phương thức trong BUS để cập nhật ca làm việc
                bool result = WorkSessionBUS.Instance.UpdateWorkSession(sessionId, employeeId, startTime, endTime);

                if (result)
                {
                    MessageBox.Show("Cập nhật ca làm việc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView2.DataSource = WorkSessionBUS.Instance.GetAllWorkSessions(); // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật ca làm việc thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMorning_Click(object sender, EventArgs e)
        {
            TimeSpan start = new TimeSpan(6, 0, 0); // 06:00
            TimeSpan end = new TimeSpan(12, 0, 0);  // 12:00
            dataGridView2.DataSource = WorkSessionBUS.Instance.FilterByShift(start, end);
        }

        private void buttonAfternoon_Click(object sender, EventArgs e)
        {
            TimeSpan start = new TimeSpan(12, 0, 0); // 12:00
            TimeSpan end = new TimeSpan(18, 0, 0);   // 18:00
            dataGridView2.DataSource = WorkSessionBUS.Instance.FilterByShift(start, end);
        }

        private void buttonEverning_Click(object sender, EventArgs e)
        {
            TimeSpan start = new TimeSpan(18, 0, 0); // 18:00
            TimeSpan end = new TimeSpan(23, 59, 59); // 23:59:59
            dataGridView2.DataSource = WorkSessionBUS.Instance.FilterByShift(start, end);
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int sessionId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["sessionId"].Value);

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa ca làm có mã {sessionId} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    bool success = WorkSessionBUS.Instance.DeleteWorkSession(sessionId);
                    if (success)
                    {
                        MessageBox.Show("Xóa ca làm thành công.");
                        dataGridView2.DataSource = WorkSessionBUS.Instance.GetAllWorkSessionsWithRole(); 
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ca làm để xóa.");
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            textBoxEmployeeID.Clear();
        }

        private void bt_Salary_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            //DateTime today = new DateTime(2025, 5, 20); // Thay đổi ngày tháng theo ý muốn
            DataTable salaryTable = WorkSessionBUS.Instance.GetTodaySalaryWithAmount(today);

            SalaryForm salaryForm = new SalaryForm(salaryTable);
            salaryForm.Show(); // hoặc ShowDialog() nếu muốn form modal
        }
    }
}
