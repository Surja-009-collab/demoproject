using System;

namespace demoproject
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            string str; 

            Console.Write("Enter Number 1: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2: ");
            str = Console.ReadLine(); 
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3: ");
            str = Console.ReadLine(); 
            c = Convert.ToInt32(str);

            result = Sum(a, b, c);
            Console.WriteLine("Sum : {3}", a, b, c, result);
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }

        static int Sum(int x, int y, int z)
        {
            return x + y + z; 
        }
    }
}