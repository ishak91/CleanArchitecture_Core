using System;
using System.Collections.Generic;
using System.Text;

namespace Appplication.Contracts.Infastructure.ExternalService
{
    /// <summary>
    /// //This is a sample class. Please implement your own external 3rd party integrations 
    /// 
    /// This is a sample External Integration Service Layer.
    /// Please add new interfaces for your own external 3rd party implementations
    /// 
    /// </summary>
    public interface IExternalIntegrationService
    {
        /// <summary>
        /// Sample Method
        /// </summary>
        /// <returns></returns>
        IEnumerable<SampleDTO> GetListOfData();

    }
}
