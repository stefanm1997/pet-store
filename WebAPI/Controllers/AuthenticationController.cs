using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using WebAPI.TokenAuthentication;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly TokenManager _tokenManager;
        public AuthenticationController(TokenManager tokenManager) 
        { 
            _tokenManager = tokenManager;   
        }

        /// <summary>
        /// Admin authentication
        /// </summary>
        /// <returns>Return JWT Token</returns>
        /// <response code="200">Successful authentication</response>
        /// <response code="401">Wrong username or password</response>
        [HttpPost]
        public IActionResult Authentication([FromForm] string username, [FromForm] string password)
        {
            if (_tokenManager.Authenticate(username,password))
            {
                return Ok(new { Token = _tokenManager.GenerateToken(), Message = "Your authentication is successful!"});
            }
            else
            {
                return Unauthorized("Wrong username or password!");
            }
        }       
    }
}
