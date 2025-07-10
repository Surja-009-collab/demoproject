using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int n, fact = 1;

            Console.WriteLine("Enter a positive integer: ");
            string str = Console.ReadLine();

            if (!int.TryParse(str, out n) || n.ToString().Trim() == "")
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                Console.Read();
                return;
            }

            if (n < 0)
            {
                Console.WriteLine("Error: Factorial is not defined for negative numbers.");
                Console.Read();
                return;
            }


            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial of {0} is: {1}", n, fact);
            Console.Read();
        }
    }
}
