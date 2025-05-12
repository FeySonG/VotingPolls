using Application.Abstractions;
using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application.Features.Users.ChangeUserRole
{
    public record ChangeUserRoleCommand(UserRole role, long id) : ICommand<bool>;
}
