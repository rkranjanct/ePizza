using ePizza.Domain.Interfaces;
using ePizza.Infrastructure.Entities;
using ePizza.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            string connectionString
            )
        {
            services.AddDbContext<ePizzaDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IItemRepository, ItemRepository>();

            return services;
        
        }
    }
}
