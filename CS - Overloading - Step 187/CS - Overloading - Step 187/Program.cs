/*
Overload the "==" operator so it checks if two Employee objects are equal 
by comparing their Id property.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CS___Overloading___Step_187
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            Compare EmpId1 = new Compare(100);
            Compare EmpId2 = new Compare(105);

            Compare Check operator== (EmpId1, EmpId2);
            Console.WriteLine(Compare.Check.operator==);
        }
    }
}

