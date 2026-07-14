using ePizza.Application.Implementation;
using ePizza.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace ePizza.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddScoped<IItemService,ItemService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenGeneratorService, TokenGeneratorService>();
            return services;
        }
    }
}
