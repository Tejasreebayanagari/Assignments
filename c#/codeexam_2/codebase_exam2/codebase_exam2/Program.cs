using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase_exam2
{
    public delegate void calculator(int a, int b);

    class Program
    {
        
        public static void addition(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("\t\n---------------ADDITION-------------");
            Console.WriteLine("\n\nAddition result is {0}");
        }
        public static void substraction(int a, int b)
        {
            int res = a - b;
            Console.WriteLine("\t\n---------------SUBSTRACTION----------");
            Console.WriteLine("\n\nSubstraction result is {0}");
        }
        public static void multiplication(int a, int b)
        {
            int res = a * b;
            Console.WriteLine("\t\n---------------MULTIPLICATION-----------");
            Console.WriteLine("\n\nMultiplicatio result is {0}");
        }
        public static void division(int a, int b)
        {
            int res = a / b;
            Console.WriteLine("\t\n---------------DIVISION------------");
            Console.WriteLine("\n\nDivision result is {0}");
        }
        static void Main(string[] args)
        {
            calculator obj = new calculator(Program.addition);
            obj.Invoke(10, 20);
            obj = substraction;
            obj(20, 10);
            obj = multiplication;
            obj(35, 53);
            obj = division;
            obj(50, 10);
            Console.ReadLine();
        }
    }
}