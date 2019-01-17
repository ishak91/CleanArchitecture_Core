using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Contracts.Repository
{

    /// <summary>
    /// IRepository Context , Unit of Work Implementation
    /// </summary>
    /// <typeparam name="T_Id">Id Type</typeparam>
    public interface IRepositoryContext
     {
        /// <summary>
        /// Get repository for a entity type
        /// </summary>
        /// <typeparam name="T_Entity">Entity Type</typeparam>
        /// <returns>Repository for Entity</returns>
        IRepository<T_Entity> GetRepository<T_Entity>() where T_Entity : class;

        /// <summary>
        /// Commit changes to database
        /// </summary>
        /// <returns>Int</returns>
        int Commit();

        /// <summary>
        /// Commit changes to database async
        /// </summary>
        /// <returns></returns>
        Task<int> CommitAsync();
    }

}
