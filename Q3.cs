using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Q3
    {
        // Entry point for this file if compiled standalone
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                if (number % 2 == 0)
                    Console.WriteLine($"{number} is even.");
                else
                    Console.WriteLine($"{number} is odd.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
