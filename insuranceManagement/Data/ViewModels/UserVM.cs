using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.ViewModels
{
    public class UserVM
    {
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public int phone { get; set; }
        public string role { get; set; }
        public DateTime dob { get; set; }
    }
}
