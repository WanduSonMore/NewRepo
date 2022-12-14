using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Please enter your location: ");
            var location = Console.ReadLine();

            // 3.
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You are in " + location);

            // 4.
            var currentDate = DateTime.Now;
            //Console.WriteLine($"The current date is {currentDate.ToLongDateString()}");
            Console.WriteLine($"The current date is {currentDate.ToString("D")}");
            //Console.WriteLine($"The current date is {currentDate:d}");
            //Console.WriteLine($"The current date is {currentDate:D}");

            // 5. 
            var nextChristmas = new DateTime(currentDate.Year, 12, 25);
            var daysUntilChristmas = nextChristmas - currentDate;
            Console.WriteLine($"There are {daysUntilChristmas.Days} days until Christmas.");

            // 6.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = Console.ReadLine();

            width = double.Parse(widthString);

            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // 7.
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
