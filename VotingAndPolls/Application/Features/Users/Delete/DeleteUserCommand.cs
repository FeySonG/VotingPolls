using Application.Abstractions;

namespace Application.Features.Users.Delete
{
    public record DeleteUserCommand(long id) : ICommand<bool>;
}
