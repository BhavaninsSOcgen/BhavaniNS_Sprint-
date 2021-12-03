using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprint2Project.Models;
using Sprint2Project.Interface;

// login Api

namespace Sprint2Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpGet]
        public string CheckLogin(string Username, string password)
        {
            //logic to check for login credentials from database(sprint 2 )
            // Will create the correct logic in sprint 2 
            var up = new UserModule();
            if (Username != up.Email || password != up.Password)
            {
                return "Valid";
            }
            else
            {
                return "InValid";
            }
        }

    }
}
