using Application.Abstractions;
using Application.Services;
using Domain.Models.Users;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Application.Features.Users.Auth.LogIn
{
    public class LogInUserQueryHandler : IQueryHandler<LogInUserQuery, User>
    {
        private readonly HttpContext _httpContext;
        private readonly IUserRepository _userRepository;
        private readonly IPasswordService _passwordService;

        public LogInUserQueryHandler(IHttpContextAccessor accessor
        , IUserRepository userRepository
        , IPasswordService passwordService)
        {
            if (accessor.HttpContext is null)
            {
                throw new ArgumentException(nameof(accessor.HttpContext));
            }
            _passwordService = passwordService;
            _userRepository = userRepository;
            _httpContext = accessor.HttpContext;
        }
        public async Task<User?> Handle(LogInUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmailAsync(request.email);

            if (user == null) return null;
            await LoginHttpContext(user);
            return user;
        }

        private Task LoginHttpContext(User user)
        {

            var claims = new Claim[]
            {
            new (ClaimTypes.NameIdentifier, user.Id.ToString() ),
            new (ClaimTypes.Email, user.Email),
            new (ClaimTypes.Role, user.Role.ToString()),
            new (ClaimTypes.Expiration, DateTime.UtcNow.AddHours(5).ToString()),
            };
            var identity = new ClaimsIdentity(claims, "Coockies");
            var principal = new ClaimsPrincipal(identity);

            return _httpContext.SignInAsync(principal);
        }
    }
}
