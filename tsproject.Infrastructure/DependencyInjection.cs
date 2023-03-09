
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tsproject.Core.Context;
using tsproject.Core.Contexts;
using tsproject.Core.Repository;
using tsproject.Infrastructure.Contexts;
using tsproject.Infrastructure.Repository;
namespace tsproject.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("MySqlConnection");

            //services.AddDbContext<IApplicationContextEF, ApplicationContextEF>(options =>
            // options.UseMySql(
            //     connectionString,
            //     ServerVersion.AutoDetect(connectionString),
            //     options => options.EnableRetryOnFailure(
            //         maxRetryCount: 5,
            //         maxRetryDelay: System.TimeSpan.FromSeconds(30),
            //         errorNumbersToAdd: null
            //         )
             //));

            services.AddSingleton<IApplicationContextDapper, ApplicationContextDapper>();
            services.AddScoped<IDirectoryRepository, DirectoryRepository>();
            services.AddScoped<INotepadRepository, NotepadRepository>();
            services.AddScoped<INoteRepository, NoteRepository>();
            return services;

        }
    }


}
