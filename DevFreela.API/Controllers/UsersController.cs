using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {


        [HttpGet("{id}")]

        public IActionResult GetById(int id     )
        {

            return Ok();
        
        }


        // api / users

        [HttpPost]
       public IActionResult Post([FromBody] CreateUserModel createUserModel )
        {

            return CreatedAtAction(nameof(GetById), new { id = 1}, createUserModel);
        }



        //api/users/1login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel loginModel)
        {

            return NoContent();

        }



    }
}
