
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tsproject.Core.Context;

namespace tsproject.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("SecondConnection");

            services.AddDBContext<IApplicationContextEF, ApplicationContextEF>(options =>
             options.UseMssql(
                 connectionString,
                 ServerVersion.AutoDetect(connectionString),
                 options => options.EnableRetryonFailure(
                     maxRetryCount: 5,
                     maxRetryDelay: System.TimeSpan.FromSeconds(30),
                     errorNumbersToAdd: null
                     )
             );
            return services;
        }
    }
}
