/*
 1. Create an abstract class called Person with two properties: string firstName and string lastName.

2. Give it the method SayName().

3. Create another class called Employee and have it inherit from the Person class.

4. Implement the SayName() method inside of the Employee class.

5. Inside the Main() method, instantiate an Employee object with 
firstName "Sample" and lastName "Student". Call the SayName() method on the object.

STEP 187
/*
Overload the "==" operator so it checks if two Employee objects are equal 
by comparing their Id property.


Step 203
 1. In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, 
as well as an Id. At least two employees should have the first name "Joe".

2. Using a foreach loop, create a new list of all employees with the first name "Joe".

3. Do the same thing again, but this time with a lambda expression.

4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
*/


using System;
using System.Collections.Generic;

namespace CS___Abstract_Class___Step_179
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmpList = new List<Employee>();
            Employee Emp1 = new Employee();
            Emp1.FirstName = "Joe";
            Emp1.LastName = "Rogan";
            Emp1.id = 1;
            EmpList.Add(Emp1);

            Employee Emp2 = new Employee();
            Emp2.FirstName = "John";
            Emp2.LastName = "Cena";
            Emp2.id = 2;
            EmpList.Add(Emp2);

            Employee Emp3 = new Employee();
            Emp3.FirstName = "Dwayne";
            Emp3.LastName = "Johnson";
            Emp3.id = 3;
            EmpList.Add(Emp3);

            Employee Emp4 = new Employee();
            Emp4.FirstName = "Katniss";
            Emp4.LastName = "Everdeen";
            Emp4.id = 4;
            EmpList.Add(Emp4);

            Employee Emp5 = new Employee();
            Emp5.FirstName = "Homer";
            Emp5.LastName = "Simpson";
            Emp5.id = 5;
            EmpList.Add(Emp5);

            Employee Emp6 = new Employee();
            Emp6.FirstName = "Joe";
            Emp6.LastName = "Pesci";
            Emp6.id = 6;
            EmpList.Add(Emp6);

            Employee Emp7 = new Employee();
            Emp7.FirstName = "Jack";
            Emp7.LastName = "Sparrow";
            Emp7.id = 7;
            EmpList.Add(Emp7);

            Employee Emp8 = new Employee();
            Emp8.FirstName = "Lloyd";
            Emp8.LastName = "Christmas";
            Emp8.id = 8;
            EmpList.Add(Emp8);

            Employee Emp9 = new Employee();
            Emp9.FirstName = "Darth";
            Emp9.LastName = "Vader";
            Emp9.id = 9;
            EmpList.Add(Emp9);

            Employee Emp10 = new Employee();
            Emp10.FirstName = "Sarah";
            Emp10.LastName = "Connor";
            Emp10.id = 10;
            EmpList.Add(Emp10);

            

            List<Employee> JoeList = new List<Employee>();

            foreach (List names in EmpList)
            {
                if (names == "Joe")
                {
                    
                }

            }
            
            int i = 0;
            for (i < EmpList.Count; i++)
            {
                if (FirstName == "Joe")
                {
                    JoeList.Add(EmpList.FirstName + EmpList.LastName + EmpList.id);
                }

            }
            Console.WriteLine(JoeList);
        }
    }
}
            
  
            
           


            //Employee Person = new Employee();
            //Person.FirstName = new string("Sample");
            //Person.LastName = new string("Student");
            //Person.SayName();
            //Console.ReadLine();

            //IQuittable Resign = new Employee() { FirstName = "John", LastName = "Smith" };
            //Resign.Quit();
            //Console.ReadLine();

            //IQuittable.Resign = "John";
            //Console.WriteLine(IQuittable.Quit(Resign());


            //Employee nEmpId1 = new Employee(5);
            //Employee nEmpId2 = new Employee(15);

            //if (nEmpId1 == nEmpId2)   
            //    Console.WriteLine("Employee Id's match");
            //else
            //    Console.WriteLine("Employee Id's do not match");

        }
    }
}
