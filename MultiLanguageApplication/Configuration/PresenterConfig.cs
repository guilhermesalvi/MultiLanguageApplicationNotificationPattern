using Microsoft.Extensions.DependencyInjection;
using MultiLanguageApplication.Controllers.Presenters;

namespace MultiLanguageApplication.Configuration
{
    public static class PresenterConfig
    {
        public static IServiceCollection AddPresentersConfig(this IServiceCollection services)
        {
            services.AddScoped<PresenterBase>();

            return services;
        }
    }
}
