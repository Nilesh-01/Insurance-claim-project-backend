using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Models
{
    public class Vehicle
    {
        public int id { get; set; }
        [Required]
        public string vehicleType { get; set; }
        [Required]
        public string vehicleModel { get; set; }
        [Required]
        public string vehicleNo { get; set; }
        [Required]
        public string registrationNo { get; set; }

        //Navigation Properties
        public int userId { get; set; }
        public User user { get; set; }
        public Policy policy { get; set; }
    }
}
