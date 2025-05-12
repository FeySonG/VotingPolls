using Application.Abstractions;
using Application.Contracts.Users;
using AutoMapper;
using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.GetAll;

public class GetAllUsersQueryHandler(IUserRepository userRepository, IMapper mapper)
    : IQueryHandler<GetAllUsersQuery, List<GetUserDto>>
{
    public async Task<List<GetUserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await userRepository.GetAllAsync();

        return mapper.Map<List<GetUserDto>>(users);
    }
}
