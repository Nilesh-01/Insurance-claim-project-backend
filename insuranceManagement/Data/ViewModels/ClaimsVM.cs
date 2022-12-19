using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.ViewModels
{
    public class ClaimsVM
    {
        public string licenseNo { get; set; }
        public DateTime dateOfAccident { get; set; }
        public string driverName { get; set; }
        public int vehicleId { get; set; }
        public string status { get; set; }

        //Navigation Properties
        public int userId { get; set; }
    }
}
