using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter your income: ");
                double income = double.Parse(Console.ReadLine());
                Console.WriteLine(AgeIncome(age, income));

            }
        }

        static string AgeIncome(int age, double income)
        {
            if (age >= 25 && age <= 35 && income >= 50000)
            {
                return "Young Professional";
            }
            else if (age >= 36 && age <= 55 && income >= 70000)
            {
                return "Middle Age Professional";
            }
            else if (age >= 56 && income < 30000)
            {
                return "Senior Citizen";
            }
            else
            {
                return "Other";
            }

        }
    }
}
