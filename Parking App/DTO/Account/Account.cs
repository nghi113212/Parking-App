using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string id;
        private string username;
        private string password;
        private string email;
        private string role;
        private bool status;

        public string Id { get { return id; } set { id = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Role { get { return role; } set { role = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public Account(string id, string username, string password) 
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

    }
}
