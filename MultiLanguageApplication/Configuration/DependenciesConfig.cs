using Microsoft.Extensions.DependencyInjection;
using MultiLanguageApplication.Services;
using MultiLanguageApplication.Services.Abstractions;

namespace MultiLanguageApplication.Configuration
{
    public static class DependenciesConfig
    {
        public static IServiceCollection AddServicesDependencies(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}
