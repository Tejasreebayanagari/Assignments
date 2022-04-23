using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //To assign integer to an array -- Average value , maximum number ,minimum number
            int n;
            Console.WriteLine("Enter array size ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int [n];
            Console.WriteLine("Enter array values: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter  array value of : " + i);
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array elements are : ");
            for (int i = 0; i < n; i++)
            
            {
                Console.WriteLine(array [i]);
            }
            Console.WriteLine("Average of the given is " + array.Average());
            Console.WriteLine("Maximum number in array is " + array .Max());
            Console.WriteLine("Minimum number in array is" + array.Min());
            Console.ReadLine();




        }
    }
}
