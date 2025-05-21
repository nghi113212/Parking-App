using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class WorkSessionBUS
    {
        private static WorkSessionBUS instance;
        public static WorkSessionBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new WorkSessionBUS();
                return instance;
            }
        }

        public bool AssignSession(int employeeId, DateTime startTime, DateTime endTime)
        {
            WorkSession session = new WorkSession
            {
                EmployeeId = employeeId,
                StartTime = startTime,
                EndTime = endTime
            };

            return WorkSessionDAO.Instance.AddSession(session);
        }

        public DataTable GetAllWorkSessions()
        {
            return WorkSessionDAO.Instance.GetAllWorkSessions();
        }
        public DataTable GetAllWorkSessionsWithRole()
        {
            return WorkSessionDAO.Instance.GetAllWorkSessionsWithRole();
        }
        public bool IsShiftFull(DateTime startTime, DateTime endTime, string role)
        {
            int count = WorkSessionDAO.Instance.CountEmployeesInShift(startTime, endTime, role);
            return count >= 7;
        }

        public bool UpdateWorkSession(int sessionId, int employeeId, DateTime startTime, DateTime endTime)
        {
            return WorkSessionDAO.Instance.UpdateWorkSession(sessionId, employeeId, startTime, endTime);
        }

        public DataTable FilterByShift(TimeSpan start, TimeSpan end)
        {
            return WorkSessionDAO.Instance.GetWorkSessionsByShift(start, end);
        }

        public bool DeleteWorkSession(int sessionId)
        {
            return WorkSessionDAO.Instance.DeleteWorkSession(sessionId);
        }

        public DataTable GetTodaySalaryWithAmount(DateTime today)
        {
            DataTable raw = WorkSessionDAO.Instance.GetTodaySalary(today);
            DataTable result = raw.Clone(); // copy cấu trúc (cột, kiểu)

            // Nếu cột salary đã có trong raw, không cần thêm nữa, 
            // hoặc đổi tên cột mới, ví dụ: "calculatedSalary"
            if (!result.Columns.Contains("calculatedSalary"))
            {
                result.Columns.Add("calculatedSalary", typeof(double));
            }

            // Giả sử raw có cột totalHours, không phải totalMinutes
            foreach (DataRow row in raw.Rows)
            {
                DataRow newRow = result.NewRow();

                newRow["employeeId"] = row["employeeId"];
                newRow["name"] = row["name"];
                newRow["role"] = row["role"];
                newRow["totalHours"] = row["totalHours"];

                // Lấy tổng giờ làm
                double totalHours = Convert.ToDouble(row["totalHours"]);

                // Lương theo giờ, có thể điều chỉnh theo role nếu muốn
                double hourlyRate;
                string role = row["role"].ToString();
                switch (role)
                {
                    case "Kỹ thuật viên":
                        hourlyRate = 80000;
                        break;
                    case "Tiếp tân":
                        hourlyRate = 50000;
                        break;
                    default:
                        hourlyRate = 0;  // Hoặc giá trị mặc định nếu role không xác định
                        break;
                }
                // Tính lương = tổng giờ * lương giờ
                double salary = totalHours * hourlyRate;

                newRow["calculatedSalary"] = salary;

                result.Rows.Add(newRow);
            }

            return result;
        }
    }
}
