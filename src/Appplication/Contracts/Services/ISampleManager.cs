using Appplication.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Contracts.Services
{
    /// <summary>
    /// This is a sample manager class template
    /// </summary>
    public interface ISampleManager
    {
        /// <summary>
        /// Get All Dto1 Object Async
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Dto1>> GetAllDto1Async();

        /// <summary>
        /// Sample Add method
        /// </summary>
        /// <param name="dto1">Object 1</param>
        /// <param name="dto2">Object 2</param>
        /// <returns></returns>
        Task AddAsync(Dto1 dto1, Dto2 dto2);
    }
}
