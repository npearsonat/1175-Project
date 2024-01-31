using System;
using static System.Console;

namespace SalariesApp
{
    class SalariesApp
    {
        // Main method. I separated it from the rest RunProgram method so the user can repeat the whole thing multiple times, as the directions say. 
        // The user is prompted after RunProgram finishes to input the right character if they wish to continue
        // I used ReadLine() for char because it was messing up the other ReadLines later on if I used Read().  
        static void Main()
        {
            char pEnd = 'c';
            while (pEnd == 'c') 
            {
                RunProgram();
                pEnd = Convert.ToChar(Console.ReadLine());
            }

        }

        public static void RunProgram()
        {
            //Creates new Salaries Array

            Salaries monthlySalaries = new Salaries();

            WriteLine("Input Monthly Salaries");
            WriteLine("**********************\n");
            WriteLine("Enter Values for monthly salaries between 3000-5000");

            // This for loop is designed so the user must enter a number between 3000 and 5000 or else they will be prompted to re-enter their number.
            // The first part is for entering each month
            for (int i = 0; i < 12; i++)
            {

                int month = i + 1;
                Write("Enter salary for month {0}: ", month);
                double value = Convert.ToDouble(Console.ReadLine());
                //If the value is good then it will assign it to the array index
                if (value > 2999 && value < 5001)
                {
                    monthlySalaries.months[i] = value;
                }
                // If the value is bad then it will keep asking for one until it is between 3000 and 5000
                else
                {
                    while (value < 3000 || value > 5000)
                    {
                        WriteLine("Improper Value Entered. Please Enter Value from 3000-5000");
                        value = Convert.ToDouble(Console.ReadLine());
                        if (value > 2999 && value < 5001)
                        {
                            monthlySalaries.months[i] = value;
                            break;
                        }
                    }
                }
            }

            //This part just uses WriteLine to show the results for various methods

            WriteLine("\nSalary Statistics\n*****************\n");
            WriteLine("Total Annual Salary\t\t\t\t{0:C}", monthlySalaries.ComputeTotalSalary());
            WriteLine("Average Salary\t\t\t\t\t{0:C}", monthlySalaries.ComputeAverageSalary());
            WriteLine("Lowest Monthly Salary in {0}:\t\t{1:C}", monthlySalaries.GetLowestMonthName(), monthlySalaries.ComputeLowestSalary());
            WriteLine("Highest Monthly Salary in {0}:\t\t{1:C}", monthlySalaries.GetHighestMonthName(), monthlySalaries.ComputeHighestSalary());
            WriteLine("\nNumber of Months Below Average ({0:C}):\t{1}", monthlySalaries.ComputeAverageSalary(), monthlySalaries.MonthsBelowAverageSalary());
            WriteLine("\nSalary By Quarter\n************\nValues in the Salary Array\n");

            // ToString method to show the values in our array
            string quarters = monthlySalaries.ToString();
            WriteLine(quarters);

            WriteLine("\nSalaries ranged from {0} to {1}", monthlySalaries.ComputeLowestSalary(), monthlySalaries.ComputeHighestSalary());
            // Reminds user to enter char if they want to continue
            WriteLine("\nPress c to continue or e to end the program");
        
        }
       }
    }
