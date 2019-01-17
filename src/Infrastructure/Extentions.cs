using Appplication.Contracts.Infastructure.ExternalService;
using Infrastructure.ExternalService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Extentions
{
    public static class Extentions
    {
        public static IServiceCollection AddExternalServices(this IServiceCollection service)
        {
            service.AddTransient<IExternalIntegrationService, ExternalIntegrationService>();

            return service;
        }
    }
}
