using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Contracts.Persistence.EntityFrameworkCore
{
    /// <summary>
    /// Entity Framework Database Service 
    /// </summary>
    public interface IDatabaseService : IDatabase
    {
        //Set up all DbSet properties here
        DbSet<Entity1> Entity1Table { get; set; }
        DbSet<Entity2> Entity2Table { get; set; }


        //Add EF core DbContext method signatures here to access DbContext APIs from your applicatin layer

        /// <summary>
        /// Set Entity
        /// </summary>
        /// <typeparam name="EntityType"></typeparam>
        /// <returns></returns>
        DbSet<EntityType> Set<EntityType>() where EntityType : class;

        /// <summary>
        /// Add Entity
        /// </summary>
        /// <param name="entity">object</param>
        /// <returns></returns>
        EntityEntry Add(object entity);

        /// <summary>
        /// Find
        /// </summary>
        /// <typeparam name="TEntity">Entity Type</typeparam>
        /// <param name="keyValues">key values</param>
        /// <returns></returns>
        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;

        /// <summary>
        /// Find Async
        /// </summary>
        /// <typeparam name="TEntity">Entity Type</typeparam>
        /// <param name="keyValues">key values</param>
        /// <returns></returns>
        Task<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : class;

        /// <summary>
        /// Remove Entity
        /// </summary>
        /// <param name="entity">object</param>
        /// <returns></returns>
        EntityEntry Remove(object entity);

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity">object</param>
        /// <returns></returns>
        EntityEntry Update(object entity);

        /// <summary>
        /// Entry
        /// </summary>
        /// <param name="entity">object</param>
        /// <returns></returns>
        EntityEntry Entry(object entity);
    }
}
