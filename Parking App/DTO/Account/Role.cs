using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Role
    {
        private string id;
        private string roleName;

        public string Id { get { return id; } set { id = value; } }
        public string RoleName { get { return roleName; } set { roleName = value; } }
        public Role(string id, string roleName)
        {
            this.id = id;
            this.roleName = roleName;
        }
    }
}
