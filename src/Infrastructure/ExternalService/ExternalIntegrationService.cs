using Appplication.Contracts.Infastructure.ExternalService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ExternalService
{
    /// <summary>
    /// External Integration Service contract implementation
    /// </summary>
    internal class ExternalIntegrationService : IExternalIntegrationService
    {
        public IEnumerable<SampleDTO> GetListOfData()
        {
            return new List<SampleDTO>();
        }
    }
}
