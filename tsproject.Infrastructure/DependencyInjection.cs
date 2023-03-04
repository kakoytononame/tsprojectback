
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tsproject.Core.Context;
using tsproject.Infrastructure.Contexts;
namespace tsproject.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("SecondConnection");

            services.AddDbContext<IApplicationContextEF, ApplicationContextEF>(options =>
             options.UseMysql(
                 connectionString,
                 ServerVersion.AutoDetect(connectionString),
                 options => options.EnableRetryonFailure(
                     maxRetryCount: 5,
                     maxRetryDelay: System.TimeSpan.FromSeconds(30),
                     errorNumbersToAdd: null
                     )
             ));
            return services;
        }
    }
}
