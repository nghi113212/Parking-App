using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class RoleBUS
    {
        private static RoleBUS instance;
        public static RoleBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoleBUS();
                return instance;
            }
        }

        private RoleBUS() { }

        public List<dynamic> GetRoles()
        {
            var roles = RoleDAO.Instance.GetRoles();
            return roles.Select(r => new { Id = r.Id, RoleName = r.RoleName }).ToList<dynamic>();
        }
    }
}
