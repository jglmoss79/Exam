using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leap_Year
{
    public class DuplicatedCharsReturn : IOperationsDuplicates
    {
        public ArrayList returnArrayWithDuplicateds(string stg1, string stg2)
        {
            char[] arr1 = stg1.ToCharArray();
            char[] arr2 = stg2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            ArrayList temp = new ArrayList();

            for (int i1 = 0; i1 < arr1.Length; i1++)
            {
                for (int i2 = 0; i2 < arr2.Length; i2++)
                {
                    if (arr1[i1] == arr2[i2])
                    {
                        temp.Add(arr2[i2]);
                    }
                }
            }
            return temp;
        }
    }
}