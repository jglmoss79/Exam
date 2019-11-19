using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Leap_Year
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region variables
            string value1 = string.Empty;
            string value2A = string.Empty;
            string value2B = string.Empty;
            string value3 = string.Empty;
            string value4 = string.Empty;
            string print_message1 = "Please introduce a date eg - dd/mm/yyyy:";
            string print_message2A = "Please introduce the first string of characters";
            string print_message2B = "Please introduce the second string of characters";
            string print_message2C = "Duplicate(s) : ";
            string print_message3 = "Please introduce the characters for compression : ";
            string print_message4 = "Please introduce the bracket sequence to validate : ";
            #endregion

            #region code
            //leap year
            Console.WriteLine(print_message1);
            value1 = Console.ReadLine();
            IOperationsLeapYear dateTime = new DateTimeHelper();
            Console.WriteLine(dateTime.IsLeapYear(Convert.ToString(value1)));
            Console.ReadKey();

            //repeated characters
            Console.WriteLine(print_message2A);
            value2A = Console.ReadLine();
            Console.WriteLine(print_message2B);
            value2B = Console.ReadLine();
            Console.WriteLine(print_message2C);
            IOperationsDuplicates returnDuplicates = new DuplicatedCharsReturn();
            returnDuplicates.returnArrayWithDuplicateds(value2A.ToLower(), value2B.ToLower()).Cast<char>().Distinct().ToList().ForEach(i => Console.WriteLine(i));
            Console.ReadKey();

            //Compression
            Console.WriteLine(print_message3);
            value3 = Console.ReadLine();
            IOperationsCompressed arrayCompressed = new CompressedString();
            var qq1 = arrayCompressed.stringCompressor(value3.ToLower()).Cast<string>().ToArray();
            Console.WriteLine(string.Join("", qq1));
            Console.ReadKey();

            //brackets validator
            Console.WriteLine(print_message4);
            value4 = Console.ReadLine();
            IOperationsBracketsValidators BracketValidator = new BracketValidator();
            bool myBracketValidator = BracketValidator.bracketValidator(value4.ToLower());
            Console.WriteLine("Validation is:" + myBracketValidator);
            Console.ReadKey();

            //cartesian plane
            int[,] array1 = new int[,] { {0,0}, {-1,1}, {1, -1}, {1, 1}, {-1, -1} };
            //int[,] array1 = new int[,] { { 0, 0 }, { -2, 1 }, { 1, -1 }, { 1, 1 }, { -1, -1 } };
            IOperationsCalculateArea area = new CalculateAreaOfCartesianPlane();
            Console.WriteLine("The bounding box's area of points is " + area.calculateArea(array1));
            Console.ReadKey();

            #endregion
        }     
    }
}