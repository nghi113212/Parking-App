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
    public partial class DashBoardForm : Form
    {
        private string username;
        private string role;
        public DashBoardForm()
        {
            InitializeComponent();
        }

        public DashBoardForm(string role)
        {
            InitializeComponent();
            this.role = role;
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            if (role == "1") // Admin
            {
                // show all
            }
            else if (role == "2") // Manager
            {
                adminToolStripMenuItem.Enabled = false;
                adminToolStripMenuItem.Visible = false;
            }
            else if (role == "Tiếp tân") 
            {
                adminToolStripMenuItem.Enabled = false;
                mANAGESTAFFToolStripMenuItem.Enabled = false;
                mANAGEWORKToolStripMenuItem.Enabled = false;
                mANAGEEXPERTISEToolStripMenuItem.Enabled = false;

                adminToolStripMenuItem.Visible = false;
                mANAGESTAFFToolStripMenuItem.Visible = false;
                mANAGEWORKToolStripMenuItem.Visible = false;
                mANAGEEXPERTISEToolStripMenuItem.Visible = false;
            }
            else if(role == "Trông xe")
            {
                adminToolStripMenuItem.Visible = false;
                mANAGESTAFFToolStripMenuItem.Visible = false;
                mANAGEWORKToolStripMenuItem.Visible = false;
                mANAGEEXPERTISEToolStripMenuItem.Visible = false;
                mANAGECONTRACTToolStripMenuItem.Visible = false;
                cUSTOMERToolStripMenuItem.Visible = false;
                rEVENUEToolStripMenuItem.Visible = false;

            } else if (role =="Kỹ thuật viên")
            {
                adminToolStripMenuItem.Visible = false;
                mANAGESTAFFToolStripMenuItem.Visible = false;
                mANAGEWORKToolStripMenuItem.Visible = false;
                mANAGECONTRACTToolStripMenuItem.Visible = false;
                mANAGEVEHICLEToolStripMenuItem.Visible = false;
                mANAGEPOSITIONToolStripMenuItem.Visible = false;
                cUSTOMERToolStripMenuItem.Visible = false;
                rEVENUEToolStripMenuItem.Visible = false;
            }

            //else if (role == "Kỹ thuật viên")
            //{
            //    btnManageUsers.Visible = false;
            //    btnReports.Visible = false;
            //}
            //else if (role == "Trông xe")
            //{
            //    btnManageUsers.Visible = false;
            //    btnReports.Visible = false;
            //    btnManageVehicles.Visible = false;
            //}
        }



        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new HomePageForm());
        }

        private void LoadFormIntoPanel(Form childForm)
        {
            panelContainer.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            childForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new HomePageForm());
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new AdminForm());
        }

        private void mANAGEVEHICLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageVehicleForm());
        }

        public event EventHandler Logout;
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Ẩn Dashboard (không đóng)

                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    this.Show(); // Nếu đăng nhập lại, show Dashboard
                }
                else
                {
                    this.Close(); // Nếu không login lại, thì đóng app
                }
            }
        }

        private void mANAGEPOSITIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new PositionForm());
        }

        private void cUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageCustomerForm());
        }

        private void mANAGECONTRACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageContractForm());
        }

        private void mANAGESTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageStaffForm());
        }

        private void mANAGEWORKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManageWorkForm());
        }

        private void mANAGEEXPERTISEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new WorkLogForm());
        }

        private void rEVENUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new RevenueForm());
        }
    }
}
