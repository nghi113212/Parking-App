using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkSession
    {
        public int SessionId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public double GetHoursWorked()
        {
            return (EndTime - StartTime).TotalHours;
        }
    }
}
