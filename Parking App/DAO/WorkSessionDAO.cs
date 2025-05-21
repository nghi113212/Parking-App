using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;  

namespace DAO
{
    public class WorkSessionDAO
    {
        private static WorkSessionDAO instance;
        public static WorkSessionDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new WorkSessionDAO();
                return instance;
            }
        }

        public bool AddSession(WorkSession session)
        {
            string query = "INSERT INTO WorkSession (employeeId, startTime, endTime) VALUES (@employeeId, @startTime, @endTime)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@employeeId", session.EmployeeId),
                new SqlParameter("@startTime", session.StartTime),
                new SqlParameter("@endTime", session.EndTime)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllWorkSessions()
        {
            string query = "SELECT * FROM WorkSession";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int CountEmployeesInShift(DateTime startTime, DateTime endTime, string role)
        {
            string query = @"
            SELECT COUNT(*) FROM WorkSession ws
            JOIN Employee e ON ws.employeeId = e.employeeId
            WHERE
            e.role = @role AND
            (
                (ws.startTime < @endTime AND ws.endTime > @startTime )
            )";

            object[] parameters = { role, endTime, startTime };

            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        public bool UpdateWorkSession(int sessionId, int employeeId, DateTime startTime, DateTime endTime)
        {
            string query = @"
            UPDATE WorkSession 
            SET employeeId = @employeeId, startTime = @startTime, endTime = @endTime
            WHERE sessionId = @sessionId";

            SqlParameter[] parameters = {
                new SqlParameter("@sessionId", sessionId),
                new SqlParameter("@employeeId", employeeId),
                new SqlParameter("@startTime", startTime),
                new SqlParameter("@endTime", endTime)
            };

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;  // Nếu có dòng bị ảnh hưởng thì trả về true
        }

        public DataTable GetAllWorkSessionsWithRole()
        {
            string query = @"
            SELECT ws.sessionId, ws.employeeId, ws.startTime, ws.endTime, e.role
            FROM WorkSession ws
            JOIN Employee e ON ws.employeeId = e.employeeId";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetWorkSessionsByShift(TimeSpan startShift, TimeSpan endShift)
        {
            string query = @"
            SELECT ws.sessionId, ws.employeeId, ws.startTime, ws.endTime, e.role
            FROM WorkSession ws
            JOIN Employee e ON ws.employeeId = e.employeeId
            WHERE 
                CAST(ws.startTime AS TIME) >= @startShift AND
                CAST(ws.startTime AS TIME) < @endShift";

            object[] parameters = { startShift, endShift };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public bool DeleteWorkSession(int sessionId)
        {
            string query = "DELETE FROM WorkSession WHERE sessionId = @sessionId";
            SqlParameter[] parameters = {
                new SqlParameter("@sessionId", sessionId)
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public DataTable GetTodaySalary(DateTime date)
        {
            string query = @"
            SELECT e.employeeId, e.name, e.role,
                   SUM(DATEDIFF(MINUTE, ws.startTime, ws.endTime)) / 60.0 AS totalHours,
                   SUM(DATEDIFF(MINUTE, ws.startTime, ws.endTime)) / 60.0 * 
                   CASE 
                       WHEN e.role = 'Sáng' THEN 5 
                       WHEN e.role = 'Chiều' THEN 6 
                       WHEN e.role = 'Tối' THEN 7 
                       ELSE 0 
                   END AS calculatedSalary
            FROM WorkSession ws
            JOIN Employee e ON ws.employeeId = e.employeeId
            WHERE CAST(ws.startTime AS DATE) = @date
            GROUP BY e.employeeId, e.name, e.role";

            object[] parameters = { date };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
