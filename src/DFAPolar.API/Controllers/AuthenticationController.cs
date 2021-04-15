using AutoMapper;
using DFAPolar.API.Dtos;
using DFAPolar.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Threading.Tasks;

namespace DFAPolar.Controllers
{
    /// <summary>
    /// Authentication Controller
    /// </summary>
    [Produces("application/json")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
    [ProducesResponseType((int)HttpStatusCode.Forbidden)]
    [ApiVersion("1.0")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;
        private IConfiguration _config;

        public AuthenticationController(IUserService userService, IMapper mapper, IConfiguration config)
        {
            _userService = userService;
            _mapper = mapper;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] UserResultDto userResultDto)
        {
            try
            {
                IActionResult response = Unauthorized();

                var user = await _userService.Authenticate(userResultDto.UserEmail, userResultDto.Password);

                if (user == null)
                {
                    return BadRequest(new { message = "Email or password is incorrect" });
                }

                var tokenString = _userService.GenerateJWTToken(user);

                response = Ok(new
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    Lastname = user.LastName,
                    Email = user.UserEmail,
                    Phone1 = user.PhoneOne,
                    Phone2 = user.PhoneTwo,
                    Country = user.Country,
                    OfAge = user.OfAge,
                    Role = user.UserRole,
                    Token = tokenString
                });

                return response;

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
