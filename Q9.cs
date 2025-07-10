using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Q9
    {
        static void Main(string[] args)
        {


            string name = "JoHn F kEnNedy";
            char[] chars = name.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.IsUpper(chars[i]) ? char.ToLower(chars[i]) : char.ToUpper(chars[i]);
            }
            Console.WriteLine(new string(chars));
        }
    }
}
