using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leap_Year
{
    public class LeapYearException : Exception
    {
        public LeapYearException(string message, Exception innerException)
            :base(message, innerException)
        {

        }
    }
}
