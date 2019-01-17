using Appplication.Contracts.Persistence.EntityFrameworkCore;
using Appplication.Contracts.Repository;
using Persistence.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    internal class RepositoryContext : IRepositoryContext
    {
        private readonly IDatabaseService _databaseContext;

        public RepositoryContext(IDatabaseService databaseContext)
        {
            _databaseContext = databaseContext;
        }

        /// <summary>
        /// Commit
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            return _databaseContext.SaveChanges();
        }

        /// <summary>
        /// Commit Async
        /// </summary>
        /// <returns></returns>
        public Task<int> CommitAsync()
        {
            return _databaseContext.SaveChangesAsync();
        }

        public IRepository<T_Entity> GetRepository<T_Entity>() where T_Entity : class
        {          
            return new GenericRepository<T_Entity>(_databaseContext);
        }
    }
}
