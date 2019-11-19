using System;
using System.Collections.Generic;
using System.Text;

namespace Leap_Year
{
    public class DateTimeHelper : IOperationsLeapYear
    {
        public Boolean IsLeapYear(string givenTime)
        {
            try
            {
                System.DateTime temp1 = Convert.ToDateTime(givenTime);
                if ((temp1.Year) % 4 == 0)
                {
                    if ((temp1.Year) % 100 == 0)
                    {
                        if ((temp1.Year) % 400 == 0) return true;
                    }
                }
                return false;
            }

            catch (Exception ex)
            {
                throw new LeapYearException("Datetime.IsLeapYear() can’t be used", ex);
            }

        }
    }
}