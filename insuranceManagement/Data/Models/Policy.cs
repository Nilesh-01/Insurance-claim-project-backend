using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Models
{
    public class Policy
    {
        public int id { get; set; }
        public string policyName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        //Navigation Properties
        public int vehicleId { get; set; }
        public Vehicle vehicle { get; set; }
    }
}
