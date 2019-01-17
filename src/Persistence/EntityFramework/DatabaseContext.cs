using Appplication.Contracts.Persistence.EntityFrameworkCore;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.EntityFramework
{
    /// <summary>
    /// Db Context Class
    /// </summary>
    internal class DatabaseContext : DbContext, IDatabaseService
    {
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="dbContextOptions">DbContext Options</param>
        public DatabaseContext(DbContextOptions<DatabaseContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Entity1> Entity1Table { get; set; }
        public DbSet<Entity2> Entity2Table { get; set; }

        /// <summary>
        /// OnConfiguring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// On Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyConfiugrations(modelBuilder);
        }

        /// <summary>
        /// Apply All Configuration for Entities 
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void ApplyConfiugrations(ModelBuilder modelBuilder)
        {

        }
    }
}
