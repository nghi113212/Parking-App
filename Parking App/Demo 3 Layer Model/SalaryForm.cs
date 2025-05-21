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
    public partial class SalaryForm : Form
    {
        public SalaryForm(DataTable salaryTable)
        {
            InitializeComponent();
            dataGridView1.DataSource = salaryTable;
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
