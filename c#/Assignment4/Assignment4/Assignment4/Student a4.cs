using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student

{
    internal class Program
    {
        public abstract class Student
        {
            public String Name;
            public int StudentId;
            public abstract void BooleanIspassed(int Grade);
        }
        //inherited class
        public class Undergraduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {

                    Console.WriteLine("Enter the undergraduate student Grade ");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 70)
                    {
                        Console.WriteLine("undergraduate student passed the course ");
                    }
                    else
                    {
                        Console.WriteLine("undergraduate student failed the course ");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("input mismatch exception " + e.StackTrace);
                }
            }
        }
        //derived class
        class Graduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {
                    Console.WriteLine("\nenter the graduate student Grade");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 80)
                    {
                        Console.WriteLine("graduate student passed the course ");
                    }
                    else
                    {
                        Console.WriteLine("graduate student failed the course ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("input missmatch exception " + e.StackTrace);
                }
            }
        }
        static void Main(string[] args)
        {
            Undergraduate ug = new Undergraduate();
            ug.BooleanIspassed(10);
            Console.WriteLine("Enter Student name  ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter student id number ");
            int StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Undergraduate Student name is {name} & id is {StudentId}  ");

            Graduate g = new Graduate();
            g.BooleanIspassed(20);
            Console.WriteLine("Enter Student name  ");
            String Name  = Console.ReadLine();
            Console.WriteLine("Enter student id number ");
            int Studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Graduate Student name is {Name} & id is {Studentid}");
            Console.ReadLine();
        }
    }

} 