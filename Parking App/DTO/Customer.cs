using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public int customerId { get; set; }
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string identityCard { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string gender { get; set; }

        public Customer() { }

        public Customer(int id, string fullName, string phone, string email, string address, string identityCard, DateTime? dob, string gender)
        {
            this.customerId = id;
            this.fullName = fullName;
            this.phoneNumber = phone;
            this.email = email;
            this.address = address;
            this.identityCard = identityCard;
            this.dateOfBirth = dob;
            this.gender = gender;
        }
    }
}
