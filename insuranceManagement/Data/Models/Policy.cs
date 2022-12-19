using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Models
{
    public class Policy
    {
        public int id { get; set; }
        [Required]
        public string policyName { get; set; }
        [Required]
        public DateTime startDate { get; set; }
        [Required]
        public DateTime endDate { get; set; }

        //Navigation Properties
        public int vehicleId { get; set; }
        public Vehicle vehicle { get; set; }
    }
}
