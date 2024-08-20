using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_4_PassedFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your score: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(PassedFailed(num));
            }
        }

        static string PassedFailed(int num)
        {
            return (num >= 50) ? "Passed" : "Failed";
        }
    }
}
