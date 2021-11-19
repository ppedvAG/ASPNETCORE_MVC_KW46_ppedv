using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_DI_Samples.Services
{
    public class TimeService : ITimeService
    {
        public DateTime GetCurrtentTime()
        {
            return DateTime.Now;
        }
    }
}
