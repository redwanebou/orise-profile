using Microsoft.Extensions.DependencyInjection;
using OriseProfile.Application.Interfaces;
using OriseProfile.Infrastructure.Persistence;

namespace Orise.API.Extensions
{
    public static class ApiServiceRegistration
    {
        public static void AddPresentationServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, FilePersonRepository>();
        }
    }
}
