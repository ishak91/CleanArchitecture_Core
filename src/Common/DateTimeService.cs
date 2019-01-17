using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
