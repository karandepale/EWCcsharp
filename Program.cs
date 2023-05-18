using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Random obj = new Random();
            int randomVal = obj.Next(0, 2);
            Console.WriteLine("Random value : " + randomVal);

            if(randomVal == 0)
            {
                Console.WriteLine("Employee is Absent...");
            }
            else
            {
                Console.WriteLine("Employee is Present...");
            }

        }
    }
}
