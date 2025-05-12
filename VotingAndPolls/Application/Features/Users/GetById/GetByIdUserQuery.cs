using Application.Abstractions;
using Application.Contracts.Users;

namespace Application.Features.Users.GetById;

public record GetByIdUserQuery(long Id) : IQuery<GetUserDto>;

