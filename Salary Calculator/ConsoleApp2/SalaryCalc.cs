using System;

namespace ConsoleApp2
{
    public class SalaryCalculator
    {
        public int Empid;
        public string Name;
        public string Position;

        public SalaryCalculator(int empid, string name, string  position)
        {
            this.Empid = empid;
            this.Name = name;
            this.Position = position;
        }

        public void test()
        {
            Console.WriteLine("SalaryCalculator");
        }
        
        public static double CalculateMonthlySalary(double Gs)
        {
            double MonthlySalary;
            MonthlySalary=Gs-(Gs*0.3) - (Gs*0.05) - (Gs*0.03);
            return MonthlySalary;
        }
        public static double CalculateHourlySalary(double RatePerHour, double Nofhours )
        {
            double HourlySalary;
            HourlySalary=(RatePerHour*Nofhours)-(RatePerHour*0.05)-(RatePerHour*0.03);
            return HourlySalary;
        }
        public static double CalculateOneTimeSalary(double Gs)
        {
            double OneTimeSalary ;
            OneTimeSalary=Gs-(Gs*0.03) ;
            return OneTimeSalary;
        }
    }
}