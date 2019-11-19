using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leap_Year
{
    public class BracketValidator : IOperationsBracketsValidators
    {
        public bool bracketValidator(string st)
        {
            int cont = 0;
            char[] chars = st.ToCharArray();
            ArrayList arrayBracket = new ArrayList();

            for (int w1 = 0; w1 < chars.Length; w1++)
            {
                if (chars[w1].ToString() == "(")
                {
                    arrayBracket.Add("1");
                }
                if (chars[w1].ToString() == "[")
                {
                    arrayBracket.Add("2");
                }
                if (chars[w1].ToString() == "]")
                {
                    arrayBracket.Add("2");
                }
                if (chars[w1].ToString() == ")")
                {
                    arrayBracket.Add("1");
                }
            }
            
            //Sense the incorrect opening - closing brackets
            var arrayTest = arrayBracket.Cast<string>().ToArray();
            string q = string.Join("", arrayTest);
            if (q.Contains("1212"))
            { return false; }
            if (q.Contains("2121"))
            { return false; }

            foreach (string x in arrayBracket)
            {
                if (x == "1")
                {
                    cont = cont + 1;
                }
                if (x == "2")
                {
                    cont = cont + 2;
                }
            }

            if (cont % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
