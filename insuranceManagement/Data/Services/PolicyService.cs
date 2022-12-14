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
            var _policy = new Policy()
            {
                policyName = policy.policyName,
                startDate = policy.startDate,
                endDate = policy.endDate,
                vehicleId = policy.vehicleId
            };
            _context.Policy.Add(_policy);
            
            _context.SaveChanges();


            var _vehicle = _context.Vehicle.Where(n => n.id == policy.vehicleId).FirstOrDefault();
            System.Diagnostics.Debug.WriteLine("Output" + _vehicle);
            _context.Entry(_vehicle).Reference(v => v.policy).Load();
            _vehicle.policy = _policy;
            _context.Entry(_vehicle).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //_context.Vehicle.Update(_vehicle);
            _context.SaveChanges();
        }

        public List<Policy> GetAllPolicy() => _context.Policy.ToList();

        public Policy GetPolicyById(int vehicleId) => _context.Policy.FirstOrDefault(n => n.vehicleId == vehicleId);

    }
}
