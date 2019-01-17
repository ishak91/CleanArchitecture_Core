using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{

    // Note : Don't you DateTime class from System. Always use IDateTime to get date related functions
    /// <summary>
    ///  Application Date Time Service 
    /// </summary>
    public interface IDateTime
    {
        /// <summary>
        /// Get Current Date Time 
        /// </summary>
        DateTime Now { get; }

        //Add all other date related mehtods and properties here.
    }
}
