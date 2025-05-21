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
using BUS;

namespace Demo_3_Layer_Model
{
    public partial class VehicleInfoForm : Form
    {
        
        public VehicleInfoForm(string slotName,int vehicleId, string licensePlate, string model, DateTime timeIn, int vehicle_typeId,
                       byte[] imgPlateBike, byte[] imgOwnerCarModel)
        {
            InitializeComponent();

            label_Position.Text =  slotName;

            textBoxVehicleId.Text = vehicleId.ToString().Trim();
            textBoxLicensePlate.Text = licensePlate.Trim();
            textBoxCarBrand.Text = model.Trim();
            dateTimePicker1.Value = timeIn;
            textBoxVehicleType.Text = GetVehicleTypeName(vehicle_typeId);

            if (imgPlateBike != null)
            {
                using (MemoryStream ms = new MemoryStream(imgPlateBike))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }

            if (imgOwnerCarModel != null)
            {
                using (MemoryStream ms = new MemoryStream(imgOwnerCarModel))
                {
                    pictureBox2.Image = Image.FromStream(ms);
                }
            }
        }

        private string GetVehicleTypeName(int vehicleTypeId)
        {
            switch (vehicleTypeId)
            {
                case 1: return "Ô tô";
                case 2: return "Xe máy";
                case 3: return "Xe đạp";
                default: return "Không rõ";
            }
        }

        private void VehicleInfo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label_Position;

            // Xóa phần bị bôi đen nếu lỡ focus rồi
            textBoxVehicleId.SelectionStart = textBoxVehicleId.Text.Length;
            textBoxVehicleId.SelectionLength = 0;

            textBoxLicensePlate.SelectionStart = textBoxLicensePlate.Text.Length;
            textBoxLicensePlate.SelectionLength = 0;

            textBoxCarBrand.SelectionStart = textBoxCarBrand.Text.Length;
            textBoxCarBrand.SelectionLength = 0;

            textBoxVehicleType.SelectionStart = textBoxVehicleType.Text.Length;
            textBoxVehicleType.SelectionLength = 0;
        }
    }
}
