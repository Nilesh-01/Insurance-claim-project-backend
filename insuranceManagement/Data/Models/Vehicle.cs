using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Models
{
    public class Vehicle
    {
        public int id { get; set; }
        public string vehicleType { get; set; }
        public string vehicleModel { get; set; }
        public string vehicleNo { get; set; }
        public string registrationNo { get; set; }

        //Navigation Properties
        public int userId { get; set; }
        public User user { get; set; }
        public Policy policy { get; set; }
    }
}
