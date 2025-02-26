using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Users
{
    public class User : Entity
    {
        [MaxLength(20)]
        public required string NickName { get; set; }

        [MaxLength(50)]
        public required string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        public required string Password { get; set; }

        [MaxLength(40)]
        public required string Email { get; set; }

        public UserRole Role { get; set; } = UserRole.User;

    }
}
