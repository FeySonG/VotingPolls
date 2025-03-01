using Application.Abstractions;
using Application.Services;
using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.ChangeUserRole
{
    public class ChangeUserRoleCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork) : ICommandHandler<ChangeUserRoleCommand, bool>
    {
        public async Task<bool> Handle(ChangeUserRoleCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByUserIdAsync(request.id);

            if (user == null) return false;
        
            user.Role = request.role;
            userRepository.Update(user);
            await unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
