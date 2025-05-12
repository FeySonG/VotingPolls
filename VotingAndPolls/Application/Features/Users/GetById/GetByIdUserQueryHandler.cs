using Application.Abstractions;
using Application.Contracts.Users;
using AutoMapper;
using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.GetById;

public class GetByIdUserQueryHandler(IUserRepository userRepository, IMapper mapper) : IQueryHandler<GetByIdUserQuery, GetUserDto>
{
    public async Task<GetUserDto> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetByUserIdAsync(request.Id);

        return mapper.Map<GetUserDto>(user);
    }
}
