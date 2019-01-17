using Appplication.Contracts.Persistence.EntityFrameworkCore;
using Appplication.Contracts.Repository;
using Persistence.EntityFramework;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Persistence
{
    /// <summary>
    /// Generic Repository Implemationstion
    /// </summary>
    internal class GenericRepository<T_Entity> : IRepository<T_Entity> where T_Entity:class
    {
        private readonly IDatabaseService _databaseService;

        public GenericRepository(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public IQueryable<T_Entity> Entity => _databaseService.Set<T_Entity>().AsQueryable();

        public void Add(T_Entity entity)
        {
            _databaseService.Add(entity);
        }

        public void Delete(T_Entity entity, bool hardDelete = false)
        {
            //This mehtod can support soft delete and hard delete both. Please write your own soft delete implemantation
            if (hardDelete)
                _databaseService.Remove(entity);
            else {
                // Please write your own soft delete implemantation here
                //entity.IsActive=false;  //example 
                _databaseService.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

        }

        public T_Entity Find(params string[] id)
        {
           return _databaseService.Set<T_Entity>().Find(id);
        }

        public Task<T_Entity> FindAsync(params string[] id)
        {
            return _databaseService.Set<T_Entity>().FindAsync(id);
        }

        public IQueryable<T_Entity> GetAll(Expression<Func<T_Entity, bool>> expression)
        {
            return _databaseService.Set<T_Entity>().Where(expression);
        }

        public void Update(T_Entity entity)
        {
            _databaseService.Update(entity);
        }
    }
}
