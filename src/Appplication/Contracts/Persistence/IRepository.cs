using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Contracts.Repository
{
    /// <summary>
    /// Base IRepository Contract
    /// </summary>
    public interface IRepository
    { }

    /// <summary>
    ///  Genaric IRepository Contract
    /// </summary>
    /// <typeparam name="T_Entity">Entity Type</typeparam>
    /// <typeparam name="T_Id">Id Type</typeparam>
    public interface IRepository<T_Entity,T_Id> : IRepository where T_Entity : class
    {
        /// <summary>
        /// Get IQueryable
        /// </summary>
        IQueryable<T_Entity> Entity { get; }
        
        /// <summary>
        /// Find by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T_Entity Find(params T_Id[] id);
        /// <summary>
        /// Find Async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T_Entity> FindAsync(params T_Id[] id);
        /// <summary>
        /// Get all Entities 
        /// </summary>
        /// <returns></returns>
        IQueryable<T_Entity> GetAll(Expression<Func<T_Entity, bool>> expression);

        /// <summary>
        /// Add Entity
        /// </summary>
        /// <param name="entity"></param>
        void Add(T_Entity entity);
        ///     /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <param name="hardDelete">True for delete from db unable to recover ones hard deleted</param>
        void Delete(T_Entity entity, bool hardDelete = false);
        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(T_Entity entity);
    }

    /// <summary>
    /// Genaric IRepository Contract with default string type of Id
    /// </summary>
    /// <typeparam name="T_Entity">Entity Type</typeparam>
    public interface IRepository<T_Entity> : IRepository<T_Entity, string> where T_Entity : class
    {

    }
}
