using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace SalariesApp
{
     public class Salaries
    {
        // Salary Array Initatior
        public double[] months = new double[12];

        //Computes total salary for all months
        public double ComputeTotalSalary() 
        {
            double sum = 0;
            for (int i = 0; i < 11; i++)
            {
                sum += months[i];
            }
            return sum;
               
        }
        //Computes lowest salary value
        public double ComputeLowestSalary() 
        {
            return months.Min();
        }
        //Computes highest salry value
        public double ComputeHighestSalary() 
        {
            return months.Max();
        }
        //Computes average salary
        public double ComputeAverageSalary()
        {
            return months.Average();
        }
        //Computes average salary minues the lowest month value. Was not used in main method
        public double ComputeAverageSalaryMinus1()
        {
            return (months.Sum() - months.Min())/(months.Length-1);
        }

        //Computes the number of months in the year prior to the lowest salaried month
        public int MonthsBelowAverageSalary() 
        {
            int counter = 0;
            foreach (int i in months)
            {
                if (i < months.Average())
                {
                    counter++;
                }
            }
            return counter;

        }

        //Gets the month name for the lowest salary month
        public string GetLowestMonthName() 
        {
            string MinMonth = "";

            switch (Array.IndexOf(months, months.Min()))
            {
                case 0: MinMonth = "January"; break;
                case 1: MinMonth = "February"; break;
                case 2: MinMonth = "March"; break;
                case 3: MinMonth = "April"; break;
                case 4: MinMonth = "May"; break;
                case 5: MinMonth = "June"; break;
                case 6: MinMonth = "July"; break;
                case 7: MinMonth = "August"; break;
                case 8: MinMonth = "September"; break;
                case 9: MinMonth = "October"; break;
                case 10: MinMonth = "November"; break;
                case 11: MinMonth = "December"; break;
            }
            return MinMonth;
        }

        //Gets the month name for the highest salary month
        public string GetHighestMonthName()
        {
            string MaxMonth = "";

            switch (Array.IndexOf(months, months.Max()))
            {
                case 0: MaxMonth = "January"; break;
                case 1: MaxMonth = "February"; break;
                case 2: MaxMonth = "March"; break;
                case 3: MaxMonth = "April"; break;
                case 4: MaxMonth = "May"; break;
                case 5: MaxMonth = "June"; break;
                case 6: MaxMonth = "July"; break;
                case 7: MaxMonth = "August"; break;
                case 8: MaxMonth = "September"; break;
                case 9: MaxMonth = "October"; break;
                case 10: MaxMonth = "November"; break;
                case 11: MaxMonth = "December"; break;
            }
            return MaxMonth;
        }

        //Converts the moth array to a string and puts it in a 3x4 grid

        public override string ToString()
        {
            return $"Qtr 1: \t {months[0]} \t {months[1]} \t { months[2]} \n" +
                   $"Qtr 2: \t {months[3]} \t {months[4]} \t {months[5]} \n" +
                   $"Qtr 3: \t {months[6]} \t {months[7]} \t {months[8]} \n" +
                   $"Qtr 4: \t {months[9]} \t {months[10]} \t {months[11]}";
        }


    }
}
