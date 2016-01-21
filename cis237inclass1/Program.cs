using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee0 = new Employee("Chad", "Cunningham", 600.00m);
            Employee employee1 = new Employee("Joe", "Somebody", 5.00m);

            int myNumber = 5;

            Console.WriteLine(myNumber);
            ChangeAnInt(myNumber);
            Console.WriteLine(myNumber);

            Console.WriteLine(employee0.ToString());
            ChangeAnObject(employee0);
            Console.WriteLine(employee0.ToString());




            //Console.WriteLine(employee0.GetFullName());
            //Console.WriteLine(employee0.ToString());

            // >Array of objects.
            Employee[] employeeArray = new Employee[10];

            // >Instanciate some employees into the array.
            employeeArray[0] = new Employee("Darren", "Froberg", 765.00m);
            employeeArray[1] = new Employee("Stan", "Marsh", 532.00m);
            employeeArray[2] = new Employee("Kyle", "Broflowskie", 223.00m);
            employeeArray[3] = new Employee("Eric", "Cartman", 142.00m);
            employeeArray[4] = new Employee("Kenny", "Something", 2.00m);

            // >Display everything in the array.
            foreach (Employee employee in employeeArray)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString());
                }
            }

        }

        // >Changes an integer.
        static void ChangeAnInt(int myNumber)
        {
            myNumber = 456;
        }
        // >Changes an object. Objects are passed by reference.
        static void ChangeAnObject(Employee employee)
        {
            employee.FirstName = "Thor";
        }







    }
    
}
