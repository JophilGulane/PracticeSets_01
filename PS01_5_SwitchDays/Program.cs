using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchDays();
        }

        static void SwitchDays()
        {
            bool appContinue = true;
            while (appContinue)
            {
                Console.WriteLine();
                Console.WriteLine("Please Select 'A', 'P', or 'X'");
                Console.WriteLine("'A'. Compute the area of a circle.\n'P'. Compute the perimeter of a circle.\n'X'. Exit the application.");

                Console.Write("Selected: ");
                string user_select = Console.ReadLine().ToLower();




                switch (user_select)
                {
                    case "a":
                        double radiusR = getRadius();
                        Console.WriteLine($"The Area is = {Area(radiusR)}");
                        break;
                    case "p":
                        double radiusP = getRadius();
                        Console.WriteLine($"The Perimeter is = {Perimeter(radiusP)}");
                        break;
                    case "x":
                        Console.WriteLine("Thank you for using the app");
                        appContinue = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            
        }

        static double Area(double radius)
        {
            const float pi = 3.14f;

            return pi * (radius * radius);
        }

        static double Perimeter(double radius)
        {
            const float pi = 3.14f;
            return 2 * pi * radius;
        }

        static double getRadius()
        {
        Console.Write("Enter the radius: ");
        return double.Parse(Console.ReadLine());
        }
    }
}
