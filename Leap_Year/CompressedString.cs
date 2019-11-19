using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leap_Year
{
    public class CompressedString : IOperationsCompressed
    {
        public  ArrayList stringCompressor(string input)
        {
            int cont = 0;
            int cont2 = 1;
            char[] chars = input.ToCharArray();
            char[] chars2 = new char[chars.Length + 1];

            ArrayList temp = new ArrayList();
            ArrayList temp2 = new ArrayList();

            int q2 = 0;

            for (int x1 = 0; x1 < chars.Length; x1++)
            {
                chars2[x1] = chars[x1];
            }
            chars2[chars2.Length - 1] = chars[chars.Length - 1];

            for (int x2 = 0; x2 < chars.Length; x2++)
            {
                temp2.Add(chars[x2].ToString());
            }

            foreach (char var1 in chars)
            {
                int we = temp.Count;
                if (var1.ToString() != chars2[cont2].ToString())
                {
                    cont++;
                    temp.Add(var1 + cont.ToString());
                    if (cont > 1)
                    {
                        temp.RemoveAt(we - 1);
                    }
                    cont = 0;
                }
                else
                {
                    cont++;
                    temp.Add(var1 + cont.ToString());
                    if (cont > 1)
                    {
                        temp.RemoveAt(we - 1);
                    }
                }
                cont2++;
            }
            if (temp.Count == chars.Length) return temp2;

            return temp;
        }
    }
}
