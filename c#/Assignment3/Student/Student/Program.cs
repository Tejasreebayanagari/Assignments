using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter student name : ");
            String name = Console .ReadLine();   
            Console.WriteLine("enter student roll no:");
            double rollno = Convert.ToDouble(Console.ReadLine());   
            Console.WriteLine("Enter student class ");
            double stclass = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine(" Enter Student semester");
            double semester = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Student branch");
            String branch = Console.ReadLine();
            int[] marks= new int[i];
            Console.WriteLine(" Enter marks ");
            Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            double average =marks.Average();
            Console.WriteLine(average);
            if(marks[i] < 35)
            {
                Console.WriteLine("Student fail");

            }
            else
            {
                Console.WriteLine("Student pass");
            }
            {
                Console.WriteLine("$ rollno is{rollno},name is{name},stclass is{class},semeser is {semester} , branch is {branch}");
            }
            {
                Console.WriteLine("The result is ");
            }          
        }
    }
}
