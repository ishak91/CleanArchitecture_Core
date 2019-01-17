using Appplication.Contracts.Services;
using Appplication.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appplication.Extentions
{
    public static class Extentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<ISampleManager, SampleManager>();
            return services;
        }        
    }
}
