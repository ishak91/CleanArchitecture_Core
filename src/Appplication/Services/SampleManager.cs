using Appplication.Contracts.Repository;
using Appplication.Contracts.Services;
using Appplication.Dto;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Appplication.Services
{
    /// <summary>
    /// Sample Manager contract implemantation
    /// </summary>
    internal class SampleManager : ISampleManager
    {
        private readonly IRepositoryContext _repositoryContext;
        private readonly IRepository<Entity1> _entity1Repository;
        private readonly IRepository<Entity2> _entity2Repository;

        public SampleManager(IRepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _entity1Repository = repositoryContext.GetRepository<Entity1>();
            _entity2Repository = repositoryContext.GetRepository<Entity2>();
        }

        /// <summary>
        /// Sample Add method
        /// </summary>
        /// <param name="dto1">Object 1</param>
        /// <param name="dto2">Object 2</param>
        /// <returns></returns>
        public Task AddAsync(Dto1 dto1, Dto2 dto2)
        {
            _entity1Repository.Add(new Entity1
            {
                Id = Guid.NewGuid().ToString(),
                Prop1 = dto1.Prop1,
                Prop2 = dto1.Prop2
            });

            _entity2Repository.Add(new Entity2
            {
                Id = Guid.NewGuid().ToString(),
                Prop1 = dto2.Prop1,
                Prop2 = dto2.Prop2
            });

            return _repositoryContext.CommitAsync();
        }

        /// <summary>
        /// Get All Dto1 Object Async
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Dto1>> GetAllDto1Async()
        {

            var dtoList = _entity1Repository.Entity.ToList().Select(s => new Dto1
            {
                Id = s.Id,
                Prop1=s.Prop1,
                Prop2=s.Prop2
            });
            return Task.FromResult(dtoList);
        }
    }
}
