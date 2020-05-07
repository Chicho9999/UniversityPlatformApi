using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UniversityPlatformApi.Data.Models;
using UniversityPlatformApi.Service.Interfaces;
using UniversityPlatformApi.ViewModels;

namespace UniversityPlatformApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IAuthService _authService;
        readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AuthController(IAuthService authService, IUserService userService, IMapper mapper)
        {
            _authService = authService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthData>> PostAsync([FromBody]LoginViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userService.GetUserByEmailAsync(model.EmailUserName);

            if (user == null)
            {
                return BadRequest(new { email = "no user with this email" });
            }

            var passwordValid = _authService.VerifyPassword(user, model.Password, user.Password);
            if (!passwordValid)
            {
                return BadRequest(new { password = "invalid password" });
            }

            return _authService.GetAuthDataAsync(user.UserId);
        }

        [HttpPost("register")]
        public async Task<ActionResult<AuthData>> PostAsync([FromBody]RegisterViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var emailUniq = _userService.IsEmailUniqe(model.Email);
            if (!emailUniq) return BadRequest(new { email = "user with this email already exists" });
            var usernameUniq = _userService.IsUsernameUniqe(model.Username);
            if (!usernameUniq) return BadRequest(new { username = "user with this email already exists" });

            var user = _mapper.Map<User>(model);

            user.Password = _authService.HashPassword(user, model.Password);

            await _userService.AddUserAsync(user);

            return _authService.GetAuthDataAsync(user.UserId);
        }

    }
}
