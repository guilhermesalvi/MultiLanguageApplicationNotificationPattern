using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MultiLanguageApplication.Notifications;
using System.Reflection;

namespace MultiLanguageApplication.Configuration
{
    public static class MediatRConfig
    {
        public static IServiceCollection AddMediatRConfig(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            return services;
        }
    }
}
