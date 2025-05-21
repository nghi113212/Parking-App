using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;
        public static RoleDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoleDAO();
                return instance;
            }
        }

        private RoleDAO() { }

        // Lấy danh sách các role
        public List<Role> GetRoles()
        {
            string query = "SELECT * FROM Role";
            DataTable result = new DataProvider().ExecuteQuery(query);

            List<Role> roles = new List<Role>();
            foreach (DataRow row in result.Rows)
            {
                roles.Add(new Role(row["roleId"].ToString(), row["roleName"].ToString()));
            }

            return roles;
        }


    }
}
