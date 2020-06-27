using System;
using System.Collections.Generic;
using System.Text;

namespace CS___Overloading___Step_187
{
    public class Compare
    {
        public static Check operator== (EmpId1, EmpId2)
        {
            if (EmpId1 == EmpId2)
                Console.WriteLine("Id's match");
            else
                Console.WriteLine("Id's don't match"); 
        }

        public static Check operator!= (EmpId1, EmpId2) 
        {
            if (EmpId1 != EmpId2)
                Console.WriteLine("Id's don't match");
            else
                Console.WriteLine("Id's match");
        }

    }

    
}
