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

            // Checking Employee is present or absent
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



            // Calculate Daily employee wage
            int wagePerHr = 20;
            int fullDayHr = 8;

            int DailyEmpWage = wagePerHr * fullDayHr;
            Console.WriteLine("Daily Employee wage is: " + DailyEmpWage);




            //calculate part time employee wage
            int partTimeHr = 8;
            int partTimeEmpWage = wagePerHr * partTimeHr;
            Console.WriteLine("Part time Employee wage is: " + partTimeEmpWage);
        }
    }
}
