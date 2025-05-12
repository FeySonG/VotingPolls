using Application.Abstractions;
using Application.Contracts.Users;

namespace Application.Features.Users.GetAll;

public class GetAllUsersQuery : IQuery<List<GetUserDto>>;
