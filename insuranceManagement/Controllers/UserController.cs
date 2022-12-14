using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using insuranceManagement.Data.Services;
using insuranceManagement.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace insuranceManagement.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserService _userService;
        private readonly IConfiguration _configuration;

        public UserController(UserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            var allUsers = _userService.GetAllUser();
            return Ok(allUsers);
        }

        [HttpGet("get-user-by-id/{id}")]
        public IActionResult GetUserById(int id)
        {
            var User = _userService.GetUserById(id);
            return Ok(User);
        }

        [HttpPost("add-user")]
        public IActionResult AddUser([FromBody]UserVM user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpPost("login")]
        public DataTable login([FromBody]UserVM user)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnectionString").ToString());
            SqlDataAdapter da = new SqlDataAdapter("Select * from Users where email='"+user.email+"' and password='"+user.password+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return dt;
            }
        }
    }
}