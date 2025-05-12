using Application.Abstractions;
using Application.Contracts.Users;

namespace Application.Features.Users.Auth.Registration
{
    public record RegistrUserCommand(CreateUserDto dto) : ICommand<bool>;
}
