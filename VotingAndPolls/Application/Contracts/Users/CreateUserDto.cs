using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Users
{
    public class CreateUserDto
    {
        public required string NickName { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string PasswordConfirm { get; set; }
    }
}
