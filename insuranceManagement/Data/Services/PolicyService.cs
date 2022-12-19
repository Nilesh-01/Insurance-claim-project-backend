using insuranceManagement.Data.Models;
using insuranceManagement.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Services
{
    public class PolicyService
    {
        private AppDbContext _context;
        public PolicyService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPolicy(PolicyVM policy)
        {
            var _vehicle = _context.Vehicle.Where(n => n.id == policy.vehicleId).FirstOrDefault();
            var _policy = new Policy()
            {
                policyName = policy.policyName,
                startDate = policy.startDate,
                endDate = policy.endDate,
                vehicleId = policy.vehicleId,
                //vehicle = _vehicle
            };
            _context.Policy.Add(_policy);
            _context.SaveChanges();

            //var _policyinDB = _context.Policy.Where(n => n.vehicleId == policy.vehicleId).FirstOrDefault();
            
            //_vehicle.policy = _policyinDB;
            //_context.Vehicle.AddAsync(_vehicle);
            //_context.SaveChanges();
        }

        public List<Policy> GetAllPolicy() => _context.Policy.ToList();

        public Policy GetPolicyById(int vehicleId) => _context.Policy.FirstOrDefault(n => n.vehicleId == vehicleId);

    }
}
