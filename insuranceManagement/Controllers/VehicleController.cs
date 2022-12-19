using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insuranceManagement.Data.Services;
using insuranceManagement.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace insuranceManagement.Controllers
{
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        public VehicleService _vehicleService;
        private readonly IConfiguration _configuration;

        public VehicleController(VehicleService vehicleService, IConfiguration configuration)
        {
            _vehicleService = vehicleService;
            _configuration = configuration;
        }

        [HttpGet("get-all-vehicles")]
        public IActionResult GetAllVehicles()
        {
            var allVehicles = _vehicleService.GetAllVehicle();
            return Ok(allVehicles);
        }

        [HttpGet("get-vehicle-by-userId/{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var VehiclesOfId = _vehicleService.GetVehicleByUserId(id);
            return Ok(VehiclesOfId);
        }

        [HttpGet("get-vehicle-by-vehicleId/{vehicleId}")]
        public IActionResult GetVehicleByVehicleId(int vehicleId)
        {
            var VehicleOfId = _vehicleService.GetVehicleByVehicleId(vehicleId);
            return Ok(VehicleOfId);
        }

        [HttpPost("add-vehicle")]
        public IActionResult AddUser([FromBody]VehicleVM vehicle)
        {
            _vehicleService.AddVehicle(vehicle);
            return Ok();
        }
    }
}