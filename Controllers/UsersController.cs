namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApi.Authorization;
using WebApi.Models.Users;
using WebApi.Services;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using WebApi.Entities;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private IUserService _userService;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private IMapper _mapper;

    public UsersController(IUserService userService, IHttpContextAccessor httpContextAccessor, IMapper mapper)
    {
        _userService = userService;
        _httpContextAccessor = httpContextAccessor;
        _mapper = mapper;
    }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest model)
    {
        var response = _userService.Authenticate(model, ipAddress());
        setTokenCookie(response.RefreshToken);
        return Ok(response);
    }

    [AllowAnonymous]
    [HttpPost("refresh-token")]
    public IActionResult RefreshToken()
    {
        var refreshToken = Request.Cookies["refreshToken"];
        var response = _userService.RefreshToken(refreshToken, ipAddress());
        setTokenCookie(response.RefreshToken);
        return Ok(response);
    }

    [HttpPost("revoke-token")]
    public IActionResult RevokeToken(RevokeTokenRequest model)
    {
        // accept refresh token in request body or cookie
        var token = model.Token ?? Request.Cookies["refreshToken"];

        if (string.IsNullOrEmpty(token))
            return BadRequest(new { message = "Token is required" });

        _userService.RevokeToken(token, ipAddress());
        return Ok(new { message = "Token revoked" });
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _userService.GetById(id);
        return Ok(user);
    }

    [HttpGet("{id}/refresh-tokens")]
    public IActionResult GetRefreshTokens(int id)
    {
        var user = _userService.GetById(id);
        return Ok(user.RefreshTokens);
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Create(CreateRequest model)
    {
        _userService.Create(model);
        return Ok(new { message = "User created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateRequest model)
    {
        _userService.Update(id, model);
        return Ok(new { message = "User updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _userService.Delete(id);
        return Ok(new { message = "User deleted" });
    }

    // helper methods

    private void setTokenCookie(string token)
    {
        // append cookie with refresh token to the http response
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddDays(7)
        };
        Response.Cookies.Append("refreshToken", token, cookieOptions);
    }

    private string ipAddress()
    {
        var ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress;
        if (ipAddress != null)
        {
            return ipAddress.MapToIPv4().ToString();
        }

        var headers = _httpContextAccessor.HttpContext.Request.Headers;
        if (headers.ContainsKey("X-Forwarded-For"))
        {
            return headers["X-Forwarded-For"];
        }

        // if all else fails, return empty string
        return "";


        // get source ip address for the current request
        /*if (Request.Headers.ContainsKey("X-Forwarded-For"))
            return Request.Headers["X-Forwarded-For"];
        else
            return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();*/
    }
}