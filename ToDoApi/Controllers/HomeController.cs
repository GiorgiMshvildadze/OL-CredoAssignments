// ???????????? ???????????
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Auth;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtTokenGenerator _tokenGenerator;
    private readonly UserManager<UserEntity> _userManager;
    private readonly RoleManager<RoleEntity> _roleManager;

    public AuthController(
        UserManager<UserEntity> userManager,
        RoleManager<RoleEntity> roleManager,
        JwtTokenGenerator tokenGenerator)
    {
        _tokenGenerator = tokenGenerator;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    [HttpGet]
    [Route("generate-token")]
    public IActionResult GenerateToken()
    {
        var jwt = _tokenGenerator.Generate("1");
        return Ok(jwt);
    }

    [HttpGet]
    [Route("test")]
    [Authorize("MyApiUserPolicy", AuthenticationSchemes = "Bearer")]
    public IActionResult Test()
    {
        return Ok("ok");
    }
}