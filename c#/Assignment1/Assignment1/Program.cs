using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check wheather a given number is positive or negitive
            int n1, n2;
            Console.WriteLine(" Enter 1st number ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine(" a and b are equal ");
            }
            else if (n1 != n2)
            {
                Console.WriteLine("a and b are not equal");
            }
            else
            {
                Console.WriteLine(" invalid ");
            }
            // 2. To Check given number positive or negitive
            int n3;
            Console.WriteLine("Enter the number to check wheather positive or not ");
            n3 = int.Parse(Console.ReadLine());
            if (n3 >= 0)
            {
                Console.WriteLine(" Given number is Positive ");
            }
            else
            {
                Console.WriteLine(" Given number is negitive ");
            }
            //3 Performing operations
            int n4, n5, result;
            char operation;
            Console.Write("Enter a  number :");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            n5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the operation ");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subraction");
            Console.WriteLine("3 Multiplicaton");
            Console.WriteLine("4 Division");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    result = n4 + n5;
                    Console.WriteLine(" addition of two number is : {0}", result);
                    break;
                case '2':
                    result = n4 - n5;
                    Console.WriteLine(" Subraction of two number is :{0}", result);
                    break;
                case '3':
                    result = n4 * n5;
                    Console.WriteLine("Multiplication of two numbers is :{0}", result);
                    break;
                case '4':
                    result = n4 / n5;
                    Console.WriteLine("Division of two numbers is :{0}", result);
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}


        
        
        
        
        
        
     
