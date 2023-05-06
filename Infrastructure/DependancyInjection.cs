using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Application;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public static class DependancyInjection
    {
        //iservice collection addinfrastrctureservices
        public 
        static
        
        IServiceCollection AddInfrastructureServices(
          this  IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

                            services.AddScoped<IPropertyRepo, PropertyRepo>();

            return services;
        }



    }

}