using Appplication.Contracts.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Extentions
{
    public static class Extentions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection service,Action<DbContextOptionsBuilder> options)
        {
            service.AddDbContext<DatabaseContext>(options);
            service.AddScoped<Appplication.Contracts.Persistence.EntityFrameworkCore.IDatabaseService, DatabaseContext>();
            service.AddScoped<IRepositoryContext, RepositoryContext>();
            return service;
        }
    }
}
