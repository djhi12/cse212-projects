using System;
using System.Collections.Generic;
public class Program
{
    static void Main()
    {
        var result = isLeapYear(1996);
        Console.WriteLine(result);

        result = isLeapYear(1900);
        Console.WriteLine(result);

        result = isLeapYear(2000);
        Console.WriteLine(result);

        result = isLeapYear(2003);
        Console.WriteLine(result);


        Trace.Assert(IsLeapYear(1996), "1996 should have been a leap year"); // true
        Trace.Assert(!IsLeapYear(1900), "1900 should not have been a leap year"); // false
        Trace.Assert(IsLeapYear(2000), "2000 should have been a leap year"); // true
        Trace.Assert(!IsLeapYear(2003), "2003 should not have been a leap year"); // false
    }


}

