using insuranceManagement.Data.Models;
using insuranceManagement.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Services
{
    public class ClaimsService
    {
        private AppDbContext _context;
        public ClaimsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddVehicle(ClaimsVM claims)
        {
            var _claims = new Claims()
            {
                licenseNo = claims.licenseNo,
                dateOfAccident = claims.dateOfAccident,
                driverName = claims.driverName,
                vehicleId = claims.vehicleId,
                status = claims.status,
                userId = claims.userId
            };
            _context.Claims.Add(_claims);
            _context.SaveChanges();
        }

        public List<Claims> GetAllClaims() => _context.Claims.ToList();

        public List<Claims> GetClaimsByUserId(int userId) => _context.Claims.Where(n => n.userId == userId).ToList();

        public Claims UpdateClaimsById(int id, string status)
        {
            var _claim = _context.Claims.FirstOrDefault(n => n.id == id);
            if(_claim != null)
            {
                _claim.status = status;

                _context.SaveChanges();
            }

            return (_claim);
        }
    }

}
