using Application.Abstractions;
using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Auth.LogIn
{
    public record LogInUserQuery(string email, string password) : IQuery<User>;

}
