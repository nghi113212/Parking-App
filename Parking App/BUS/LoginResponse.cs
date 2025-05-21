using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoginResponse
    {
        public LoginResult Result { get; set; }
        public string Role { get; set; }         // "Kỹ thuật viên", "Trông xe", "1", "2", etc.
        public string Username { get; set; }     // Có thể lưu thêm thông tin nếu cần
    }
}
