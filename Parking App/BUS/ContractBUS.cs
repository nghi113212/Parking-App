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
    public class ContractBUS
    {
        private static ContractBUS instance;
        public static ContractBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ContractBUS();
                return instance;
            }
        }

        private ContractBUS() { }

        public bool InsertContract(string contractType, int vehicleId, int customerId,
                           DateTime start, DateTime end, int price, int staffId, string status)
        {

            if (ContractDAO.Instance.IsVehicleCurrentlyRented(vehicleId))
            {
                MessageBox.Show("Xe này hiện đang được cho thuê và chưa hết hợp đồng.");
                return false;
            }

            if (!CustomerDAO.Instance.ExistsCustomerId(customerId))
            {
                MessageBox.Show("Khách hàng không tồn tại trong hệ thống. Vui lòng thêm khách hàng trước!");
                return false;
            }

            if(!VehicleDAO.Instance.ExistsVehicleId(vehicleId))
            {
                MessageBox.Show("Xe không tồn tại trong hệ thống. Vui lòng kiểm tra lại!");
                return false;
            }

            Contract contract = new Contract
            {
                ContractType = contractType,
                VehicleId = vehicleId,
                CustomerId = customerId,
                StartDate = start,
                EndDate = end,
                Price = price,
                StaffId = staffId,
                Status = status
            };
            // Validate contract data here if needed
            return ContractDAO.Instance.InsertContract(contract);
        }

        public bool UpdateContract(int contractId, string contractType, int vehicleId, int customerId,
                           DateTime startDate, DateTime endDate, int price)
        {
            Contract contract = new Contract
            {
                ContractId = contractId,
                ContractType = contractType,
                VehicleId = vehicleId,
                CustomerId = customerId,
                StartDate = startDate,
                EndDate = endDate,
                Price = price,
                StaffId = 1, // Assuming staffId is 1 for simplicity
                Status = "Đang hiệu lực"
            };

            return ContractDAO.Instance.UpdateContract(contract);
        }

        public DataTable GetAllContracts()
        {
            return ContractDAO.Instance.GetAllContracts();
        }

        public DataTable GetContractsByStatus(string status)
        {
            return ContractDAO.Instance.GetContractsByStatus(status);
        }

        public bool DeleteContract(int contractId)
        {
            return ContractDAO.Instance.DeleteContract(contractId);
        }

        public bool IsVehicleCurrentlyRented(int vehicleId)
        {
            return ContractDAO.Instance.IsVehicleCurrentlyRented(vehicleId);
        }

        public void UpdateExpiredContracts()
        {
            ContractDAO.Instance.UpdateExpiredContracts();
        }

        public DataTable GetContractById(int contractId)
        {
            return ContractDAO.Instance.GetContractById(contractId);
        }

        public DataTable GetContractsByLicensePlate(string licensePlate)
        {
            return ContractDAO.Instance.GetContractsByLicensePlate(licensePlate);
        }

        public int GetRentedVehicleCount()
        {
            return ContractDAO.Instance.CountRentedVehicles();
        }
    }
}
