using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employee1=new SalaryCalculator( 1, "james", "section");
            Console.WriteLine(" Employee1 salary: " + SalaryCalculator.CalculateMonthlySalary(100000));
            Console.WriteLine(" Employee1 Hourly salary:" + SalaryCalculator.CalculateHourlySalary(6, 6));
            Console.WriteLine("Employee1 One time salary:"+ SalaryCalculator.CalculateOneTimeSalary(100000));
            
        }
    }
}