using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ab = { 1, 2, 3, 4, 5 };
            foreach (int i in ab)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

