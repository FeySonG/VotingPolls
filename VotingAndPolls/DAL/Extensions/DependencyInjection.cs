using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace DAL.Extensions
{
    public static class DependencyInjection
    {
        public static void AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString(nameof(AppDbContext)));
            });

            //services.InitRepositories();
        }

        private static void InitRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IUserRepository, UserRepository>();

            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<IPasswordService, PasswordService>();


        }
    }
}
