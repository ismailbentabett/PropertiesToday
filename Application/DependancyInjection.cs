using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependancyInjection
    {

        public static IServiceCollection AddApplicationServices(
           this IServiceCollection services
        )
        {

            //add automapper 
            services.AddAutoMapper(Assembly.GetCallingAssembly()    
            );
          services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddValidatorsFromAssembly
            (
                Assembly.GetCallingAssembly()
            );
            return services;
        }
        

    }
}