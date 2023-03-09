using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tsproject.Application.Services;
using tsproject.Core.Services;

namespace tsproject.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesApplication(this IServiceCollection services,
            IConfiguration configuration)
        {


            services.AddScoped<IDirectoryService, DirectoryService>();
            services.AddScoped<INotepadService, NotepadService>();
            services.AddScoped<INoteService, NoteService>();

            return services;
        }
    }
}
