using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            String s2 = Console.ReadLine();
            if (s1.Equals(s2))
            {
                Console.WriteLine("same");
            }
            else
                Console.WriteLine("no");
            Console.ReadLine();
        }
    }
}
  

