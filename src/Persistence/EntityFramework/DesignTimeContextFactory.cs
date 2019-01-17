using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.EntityFramework
{
    internal class DesignTimeContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        private const string ConnectionString = "Server=AHAMEDISHAK-PC;Database=sample_db;Trusted_Connection=True;";
        private const string MigrationsAssembly = "Persistence";

        public DatabaseContext CreateDbContext(string[] args)
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            dbContextOptionsBuilder.UseSqlServer(ConnectionString, options=> {
                options.MigrationsAssembly(MigrationsAssembly);
            });

            var context = new DatabaseContext(dbContextOptionsBuilder.Options);

            return context;
        }
    }
}
