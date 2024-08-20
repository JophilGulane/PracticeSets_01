using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_2_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(OddEven(num));
            }
        }

        static string OddEven(int num)
        {
            if (num % 2 == 1)
            {
                return "$The number {num} is even.";
            }
            return "$The number {num} is odd.";
        }
    }
}
