using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Globalization;

namespace MultiLanguageApplication.Configuration
{
    public static class LocalizationConfig
    {
        public static IServiceCollection AddLocalizationConfig(this IServiceCollection services)
        {
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            return services;
        }

        public static IApplicationBuilder UseLocalizationConfig(this IApplicationBuilder app)
        {
            var cultures = new List<CultureInfo>
            {
                new CultureInfo("en"),
                new CultureInfo("pt")
            };

            app.UseRequestLocalization(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("en");
                options.SupportedCultures = cultures;
                options.SupportedUICultures = cultures;
            });

            return app;
        }
    }
}
