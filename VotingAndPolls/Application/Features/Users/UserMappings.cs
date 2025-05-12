using Application.Contracts.Users;
using AutoMapper;
using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users;

public class UserMappings : Profile
{
    public UserMappings()
    {
        CreateMap<User, GetUserDto>().ReverseMap();
        CreateMap<User, CreateUserDto>().ReverseMap();
        //CreateMap<User, UpdateUserDto>().ReverseMap();
    }
}
