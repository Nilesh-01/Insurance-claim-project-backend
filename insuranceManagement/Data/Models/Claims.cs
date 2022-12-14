using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Models
{
    public class Claims
    {
        public int id { get; set; }
        [Required]
        public string licenseNo { get; set; }
        [Required]
        public DateTime dateOfAccident { get; set; }
        [Required]
        public string driverName { get; set; }
        public int vehicleId { get; set; }
        public string status { get; set; }

        //Navigation Properties
        public int userId { get; set; }
        public User user { get; set; }
    }
}
