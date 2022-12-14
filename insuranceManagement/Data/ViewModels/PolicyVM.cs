using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.ViewModels
{
    public class PolicyVM
    {
        public string policyName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        //Navigation Properties
        public int vehicleId { get; set; }
    }
}
