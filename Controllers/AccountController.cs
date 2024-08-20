using Fanush.DAL.JWTService;
using Fanush.DTO;
using Fanush.Entities.Administrator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

[Route("api/[controller]")]
[ApiController]
[EnableCors("AllowOrigin")]
[AllowAnonymous]
public class AccountController : ControllerBase
{
    private readonly UserManager<AppUser> _userMgr;
    private readonly SignInManager<AppUser> _signinMgr;
    private readonly ITokenService _token;

    public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signinMgr, ITokenService token)
    {
        this._userMgr = userMgr;
        this._signinMgr = signinMgr;
        this._token = token;
    }

    //[Authorize]
    [HttpGet]
    public async Task<ActionResult<UserDTO>> GetCurrentUser()
    {
        var email = HttpContext.User?.Claims?.FirstOrDefault(a => a.Type == ClaimTypes.Email)?.Value;

        var user = await _userMgr.Users.SingleOrDefaultAsync(a => a.Email == email);

        return new UserDTO()
        {
            Email = user.Email,
            Token = _token.CreateToken(user),
            FullName = user.FullName
        };
    }

    [HttpGet("emailexists")]
    public async Task<ActionResult<bool>> CheckEmailExistsAsync([FromQuery] string email)
    {
        return await _userMgr.FindByEmailAsync(email) != null;
    }


    [HttpPost("login")]
    public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDto)
    {
        var user = await _userMgr.FindByEmailAsync(loginDto.Email);

        if (user == null)
        {
            return Unauthorized("User Not Found");
        }

        var result = await _signinMgr.CheckPasswordSignInAsync(user, loginDto.Password, false);

        if (!result.Succeeded)
        {
            return Unauthorized("Wrong Password");
        }

        return new UserDTO()
        {
            Email = user.Email,
            Token = _token.CreateToken(user),
            FullName = user.FullName
        };
    }

    [HttpPost("Register")]
    public async Task<ActionResult<UserDTO>> Register(RegisterDTO registerDTO)
    {
        var user = new AppUser()
        {
            FirstName = registerDTO.FirstName,
            LastName = registerDTO.LastName,
            Email = registerDTO.Email,
            UserName = registerDTO.Email
        };

        var result = await _userMgr.CreateAsync(user, registerDTO.Password);

        if (!result.Succeeded)
        {
            return BadRequest();
        }

        return new UserDTO()
        {
            FullName = user.FullName,
            Token = _token.CreateToken(user),
            Email = registerDTO.Email
        };
    }
}
