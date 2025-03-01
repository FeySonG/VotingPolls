using Application.Contracts.Users;
using Application.Features.Users.Auth.LogIn;
using Application.Features.Users.Auth.Registration;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace VotingAndPolls.API.Controllers;

[ApiController]
[Route("api/users")]
public class AuthController(ISender sender) : ControllerBase
{
    [HttpPost("Registration")]
    public async Task<IActionResult> Registration(CreateUserDto dto)
    {
        var response = await sender.Send(new RegistrUserCommand(dto));
        if(response = false) return BadRequest(response);
        return Ok(response);
    }

    [HttpPost("logIn")]
    public async Task<IActionResult> LogIn(string email, string password)
    {
        var result = await sender.Send(new LogInUserQuery(email, password));

        if(result == null) return BadRequest(result);

        return Ok(result);
    }

}
