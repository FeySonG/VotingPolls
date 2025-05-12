using Application.Features.Users.ChangeUserRole;
using Application.Features.Users.Delete;
using Application.Features.Users.GetAll;
using Application.Features.Users.GetById;
using Domain.Models.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace VotingAndPolls.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController(ISender sender) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await sender.Send(new GetAllUsersQuery());

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var response = await sender.Send(new GetByIdUserQuery(id));

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await sender.Send(new DeleteUserCommand(id));

            if(response == false) return BadRequest(response);

            return Ok(response);

        }

        [HttpPut]
        public async Task<IActionResult> ChangeRole(long id, UserRole role)
        {
            var response = await sender.Send(new ChangeUserRoleCommand(role, id));
            if(response == false) return BadRequest(response);
            return Ok(response);
        }

    }
}
