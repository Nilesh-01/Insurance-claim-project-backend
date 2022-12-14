using insuranceManagement.Data.Models;
using insuranceManagement.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Services
{
    public class VehicleService
    {
        private AppDbContext _context;
        public VehicleService(AppDbContext context)
        {
            _context = context;
        }

        public void AddVehicle (VehicleVM vehicle)
        {
            var _vehicle = new Vehicle()
            {
                vehicleType = vehicle.vehicleType,
                vehicleModel = vehicle.vehicleModel,
                vehicleNo = vehicle.vehicleNo,
                registrationNo = vehicle.registrationNo,
                userId = vehicle.userId
            };
            _context.Vehicle.Add(_vehicle);
            _context.SaveChanges(); 
        }

        public List<Vehicle> GetAllVehicle() => _context.Vehicle.ToList();

        public List<Vehicle> GetVehicleByUserId(int userId) => _context.Vehicle.Where(n => n.userId == userId).ToList();
    }
}
