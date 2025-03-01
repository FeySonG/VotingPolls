using DAL.Services;
using Domain.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Modules.Users
{
    internal class UserRepository(AppDbContext dbContext) : Repository<User>(dbContext), IUserRepository
    {
        public async Task<string?> CheckUniqueEmailAsync(string email)
        {
            var response = await DbContext.Users.AnyAsync(u => u.Email == email);
            if (response == true) return email;

            return null;
        }

        public async Task<string?> CheckUniqueNickNameAsync(string nickName)
        {
            var response = await DbContext.Users.AnyAsync(u => u.NickName == nickName);
            if (response == true) return nickName;
            return null;
        }

        public Task<User?> GetUserByEmailAsync(string email) => DbContext.Users.FirstOrDefaultAsync(u => u.Email == email);

        public async Task<User?> GetUserById(long Id) => await DbContext.Users.FirstOrDefaultAsync(u => u.Id == Id);
    }
}
