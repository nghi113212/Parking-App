using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_3_Layer_Model
{
    public partial class AddUnusedCarForm : Form
    {
        private int _customerId;
        private string _fullName;
        private DateTime _dateOfBirth;
        private string _identityNumber;
        private string _phoneNumber;
        private string _email;
        private string _address;
        private string _gender;
        public AddUnusedCarForm(int customerId,string fullName, DateTime dateOfBirth,
                        string identityNumber, string phoneNumber, string email,
                        string address, string gender)
        {
            InitializeComponent();
            _customerId = customerId;
            _fullName = fullName;
            _dateOfBirth = dateOfBirth;
            _identityNumber = identityNumber;
            _phoneNumber = phoneNumber;
            _email = email;
            _address = address;
            _gender = gender;
        }

        private void bt_UploadPic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bt_UploadPic2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            // Thu thập dữ liệu từ form
            int vehicleId = Convert.ToInt32(textBoxVehicleID.Text);
            string licensePlate = textBoxLicensePlate.Text;
            string model = textBoxCarBrand.Text;
            DateTime timeIn = DateTime.Now;
            int vehicleTypeId = Convert.ToInt32(comboBoxChooseCarType.SelectedValue);

            byte[] imgPlateBike = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imgPlateBike = ms.ToArray();
                }
            }

            byte[] imgOwnerCarModel = null;
            if (pictureBox2.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    imgOwnerCarModel = ms.ToArray();
                }
            }

            // Thêm xe dùng nạp chồng phương thức
            bool success = VehicleBUS.Instance.AddVehicle(
                vehicleId, licensePlate, model, timeIn, vehicleTypeId,
                imgPlateBike, imgOwnerCarModel, null, null,
                4, null, null, null, null, _customerId
            );

            if (success)
            {
                bool contractAdded = ContractBUS.Instance.InsertContract("Ký gửi",               // contractType
                    vehicleId,              // vehicleId vừa thêm
                    _customerId,            // customerId được truyền vào constructor
                    DateTime.Now,           // start
                    DateTime.Now.AddMonths(6), // end giả định 6 tháng
                    0,                      // price (có thể để 0 nếu chưa thu phí)
                    1, // staffId (hoặc hardcode nếu chưa đăng nhập)
                    "Đang xử lý"
                );

                bool addCustomer = CustomerBUS.Instance.AddCustomer(_customerId, _fullName, _phoneNumber, _email, _address, _identityNumber, _dateOfBirth, _gender);

                if (contractAdded && addCustomer)
                {
                    MessageBox.Show("Thêm xe, thêm khách hàng và tạo hợp đồng ký gửi thành công!");
                }
                else
                {
                    MessageBox.Show("Xe thêm thành công!");
                }
            }
            else
            {
                MessageBox.Show("Thêm xe thất bại!");
            }
        }

        private void AddUnusedCarForm_Load(object sender, EventArgs e)
        {
            comboBoxChooseCarType.DataSource = VehicleTypeBUS.Instance.GetAllVehicleTypes();
            comboBoxChooseCarType.DisplayMember = "vehicle_typeName";
            comboBoxChooseCarType.ValueMember = "vehicle_typeId";
        }
    }
}
