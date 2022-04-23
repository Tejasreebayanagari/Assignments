using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    internal class Program
    { 
          static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            String name = Console.ReadLine();
            String S = "";
            int n =name.Length;
            for (int i = n-1; i >=0 ; i--)
            {
                char c = name[i];
                S=S+c;
            }
            if (name.Equals(S))
                Console.WriteLine("string is palindrome " );
            else
                Console.WriteLine("String is non palindrome");
            Console.ReadLine();

        }
    }
}
