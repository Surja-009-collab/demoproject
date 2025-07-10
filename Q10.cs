using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Q10
    {
        static void Main(string[] args)
        {


            string mobile = "1234567890";
            if (mobile.Length > 6)
                Console.WriteLine(mobile.Substring(0, mobile.Length - 6) + new string('X', 6));
        }
    }
}
