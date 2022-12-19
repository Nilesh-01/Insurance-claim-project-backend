using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insuranceManagement.Data.Services;
using insuranceManagement.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace insuranceManagement.Controllers
{
    [Route("api/claims")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        public ClaimsService _claimsService;

        public ClaimsController(ClaimsService claimsService)
        {
            _claimsService = claimsService;
        }

        [HttpGet("get-all-claims")]
        public IActionResult GetAllVehicles()
        {
            var allClaims = _claimsService.GetAllClaims();
            return Ok(allClaims);
        }

        [HttpGet("get-claims-by-Userid/{id}")]
        public IActionResult GetClaimByUserId(int id)
        {
            var claim = _claimsService.GetClaimsByUserId(id);
            return Ok(claim);
        }

        [HttpPost("add-claim")]
        public IActionResult AddClaim([FromBody]ClaimsVM claim)
        {
            _claimsService.AddVehicle(claim);
            return Ok();
        }

        [HttpPut("update-claim")]
        public IActionResult UpdateClaimsById(int id, string status)
        {
            var updatedClaim = _claimsService.UpdateClaimsById(id, status);
            return Ok(updatedClaim);
        }
    }
}