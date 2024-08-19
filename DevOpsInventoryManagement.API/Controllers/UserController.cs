using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevOpsInventoryManagement.API.Mappers;
using DevOpsInventoryManagement.API.Models;
using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<User> register(UserRegisterFormDTO registerFormDTO)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            try
            {
                _userService.Register(registerFormDTO.ToEntity());
                return Created();
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<User> login(UserLoginFormDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(_userService.LoginToken(loginDTO.Login, loginDTO.Password));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
