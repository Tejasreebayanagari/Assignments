using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main()
        {
            string s = " ", reverse = " ";
            int Length;
            Console.WriteLine("Enter a string ");
            s = Console.ReadLine();
            Console.WriteLine("Length of string is :" + s.Length);
            Length = s.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + s[Length];
                Length--;
            }
            Console.WriteLine("String reverse is {0}", reverse);
            Console.ReadLine();
        }
    }
}




            
        
