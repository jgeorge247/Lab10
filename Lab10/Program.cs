using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            bool GoodCircle = true;
            while (GoodCircle)
            {
                Console.WriteLine("Welcome to the Circle Tester");
                Console.WriteLine("Please enter a radius: ");

                string Input = Console.ReadLine();
                double Radius;

                while (!double.TryParse(Input, out Radius))
                {
                    Console.WriteLine("That was invalid. Please try again.");
                    Input = Console.ReadLine();
                }

                Circle Justin = new Circle(Radius);
                counter++;

                Console.WriteLine($"The circle's area is {Justin.CalculateFormattedArea()}");
                Console.WriteLine($"The circle's circumference is {Justin.CalculateFormattedCircumference()}");

                Console.WriteLine("Would you like to continue? (Y/N)");
                string Response = Console.ReadLine();

                if (Response.ToUpper() != "Y" && Response.ToUpper() != "N")
                {
                    Console.WriteLine("That was not a valid response. Please try again");
                    Response = Console.ReadLine();
                }
                else if (Response.ToUpper() == "N")
                {
                    Console.WriteLine($"Goodbye! You created {counter} circle objects");
                    GoodCircle = false;
                }
                else if (Response.ToUpper() == "Y")
                {
                    continue;
                }
            }
        }
    }
}
