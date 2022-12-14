using insuranceManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.ViewModels
{
    public class VehicleVM
    {
        public string vehicleType { get; set; }
        public string vehicleModel { get; set; }
        public string vehicleNo { get; set; }
        public string registrationNo { get; set; }

        //Navigation Properties
        public int userId { get; set; }
    }
}
