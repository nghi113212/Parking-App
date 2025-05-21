using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS instance;
        public static BillBUS Instance
        {
            get
            {
                if (instance == null) instance = new BillBUS();
                return instance;
            }
        }

        private BillBUS() { }

        public string GetCurrentBillId(int vehicleId, int serviceId)
        {
            return BillDAO.Instance.GetCurrentBillIdByVehicleAndService(vehicleId, serviceId);
        }

        public string GetCurrentBillId2(int vehicleId, int serviceId)
        {
            return BillDAO.Instance.GetCurrentBillIdByVehicleAndService2(vehicleId, serviceId);
        }

        public string GetServiceName(int serviceId)
        {
            return BillDAO.Instance.GetServiceNameById(serviceId);
        }

        public string GetOwnerName(int vehicleId)
        {
            return BillDAO.Instance.GetOwnerNameByVehicleId(vehicleId);
        }

        public bool MarkBillAsPaid(string billId, decimal cost, decimal fine)
        {
            return BillDAO.Instance.UpdateBillOnPaid(billId, cost, fine);
        }
        public bool MarkBillAsPaid2(string billId)
        {
            return BillDAO.Instance.UpdateBillOnPaid2(billId);
        }

        public bool CreateBillFromContract(int contractId)
        {
            return BillDAO.Instance.CreateBillFromContract(contractId);
        }

        public bool UpdateBillForConsignContract(int contractId, int vehicleId, decimal price)
        {
            return BillDAO.Instance.UpdateBillForConsignContract(vehicleId, price, contractId);
        }

        public bool CompleteBill(int vehicleId, double cost, string note)
        {
            if(cost < 0)
            {
                MessageBox.Show("Vui lòng nhập chi phí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return BillDAO.Instance.UpdateBillCostAndNote(vehicleId, cost, note);
        }

        public decimal GetBillCost(int vehicleId, int serviceId)
        {
            return BillDAO.Instance.GetBillCost(vehicleId, serviceId);
        }

        public string GetBillNote(int vehicleId, int serviceId)
        {
            return BillDAO.Instance.GetBillNote(vehicleId, serviceId);
        }

        public DataTable GetRevenue(DateTime from, DateTime to)
        {
            return BillDAO.Instance.GetRevenue(from, to);
        }
    }
}
