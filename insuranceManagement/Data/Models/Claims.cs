using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Models
{
    public class Claims
    {
        public int id { get; set; }
        public string licenseNo { get; set; }
        public DateTime dateOfAccident { get; set; }
        public byte document { get; set; }

        //Navigation Properties
        public int userId { get; set; }
        public User user { get; set; }
    }
}
