using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        public int age { get; set; }
        [Required]
        public string phone { get; set; }
        public string role { get; set; }
        [Required]
        public DateTime dob { get; set; }

        //Navigation Properties
        public List<Vehicle> vehicles { get; set; }
        public List<Claims> claims { get; set; }

    }
}
