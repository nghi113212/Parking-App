using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Demo_3_Layer_Model
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            lbNumberOfCustomer.Text = CustomerBUS.Instance.GetCustomerCount().ToString();
            lbNumOfSlot.Text = SlotBUS.Instance.GetAvailableSlotCount().ToString();
            lbNumOfParkingCar.Text = VehicleBUS.Instance.GetVehicleParkingCount().ToString();
            lbNumOfStaff.Text = EmployeeBUS.Instance.GetEmployeeCount().ToString();
            lbNumOfRentedCar.Text = ContractBUS.Instance.GetRentedVehicleCount().ToString();
        }
    }
}
