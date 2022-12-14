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
    [Route("api/policy")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        public PolicyService _policyService;

        public PolicyController(PolicyService policyService)
        {
            _policyService = policyService;
        }

        [HttpGet("get-all-policy")]
        public IActionResult GetAllPolicy()
        {
            var allPolicy = _policyService.GetAllPolicy();
            return Ok(allPolicy);
        }

        [HttpGet("get-policy-by-id/{id}")]
        public IActionResult GetPolicyById(int id)
        {
            var Policy = _policyService.GetPolicyById(id);
            return Ok(Policy);
        }

        [HttpPost("add-policy")]
        public IActionResult AddPolicy([FromBody]PolicyVM policy)
        {
            _policyService.AddPolicy(policy);
            return Ok();
        }
    }
}