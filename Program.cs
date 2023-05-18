using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            // IMPLEMENTATION OF SWITCH CASE STATEMENT
            Console.WriteLine("------------- Implementing using Switch case Statement ------------------");

            // Checking Employee is present or absent
            Random obj = new Random();
            int randomVal = obj.Next(0, 2);
            Console.WriteLine("Random value: " + randomVal);

            switch (randomVal)
            {
                case 0:
                    Console.WriteLine("Employee is Absent...");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present...");
                    // Calculate Daily employee wage
                    int wagePerHr = 20;
                    int fullDayHr = 8;
                    int DailyEmpWage = wagePerHr * fullDayHr;
                    Console.WriteLine("Daily Employee wage is: " + DailyEmpWage);

                    // Calculate wages till a condition of total working hours or days is reached for a month
                    int totalWorkingHours = 100;
                    int totalWorkingDays = 20;
                    int accumulatedWage = 0;
                    int workingHours = 0;
                    int workingDays = 0;

                    while (workingHours < totalWorkingHours && workingDays < totalWorkingDays)
                    {
                        accumulatedWage += DailyEmpWage;
                        workingHours += fullDayHr;
                        workingDays++;
                    }

                    Console.WriteLine("Accumulated Wage until the condition is met: " + accumulatedWage);
                    break;
            }

            // Calculate part-time employee wage
            int partTimeHr = 8;
            int wagePerHr1 = 20;
            int partTimeEmpWage = wagePerHr1 * partTimeHr;
            Console.WriteLine("Part-time Employee wage is: " + partTimeEmpWage);
        }
    }
}
