using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Leap_Year
{
    interface IOperationsLeapYear
    {
        Boolean IsLeapYear(string givenTime);
    }

    interface IOperationsDuplicates
    {
        ArrayList returnArrayWithDuplicateds(string st1, string st2);
    }

    interface IOperationsCompressed
    {
        ArrayList stringCompressor(string input);
    }

    interface IOperationsBracketsValidators
    {
        bool bracketValidator(string st);
    }

    interface IOperationsCalculateArea
    {
        int calculateArea(int[,] arr);
    }
}
