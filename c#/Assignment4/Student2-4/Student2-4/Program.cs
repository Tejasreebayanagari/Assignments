using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student2_4
{
    internal class Program
    {
        public class Students
        {
            public int std_id;
            public string std_name;
            public double exam_fee;


            public void displayDetails()
            {
                Console.WriteLine($"\nthe student {std_name} with id {std_id} paid {exam_fee}");
            }
            public void payFee()
            {
                Console.WriteLine("Enter the student name: ");
                std_name = Console.ReadLine();
                Console.WriteLine("Enter student id: ");
                std_id = int.Parse(Console.ReadLine());
                Console.WriteLine("The exam fee: " + 1650);
                Console.WriteLine("Enter the amount to pay examfee");
                exam_fee = int.Parse(Console.ReadLine());
                double rem_fee = 1650 - exam_fee;
                if (exam_fee == 1650)
                {
                    Console.WriteLine("Full fees paid no dues");
                }
                else
                {
                    Console.WriteLine("The remaining fee: " + rem_fee);
                }
            }
        }
        class DayScholar
        {
            public double transport_fees;

            public DayScholar(double transport_fees)
            {
                Console.WriteLine("\nTransport fee : 10000");
                Console.ReadLine();
                Console.WriteLine("\nEnter the amount to pay transport fee");
                transport_fees = int.Parse(Console.ReadLine());
                this.transport_fees = transport_fees;
                double rem1_fee = 10000 - transport_fees;

                Console.WriteLine("\nThe transport fee: " + 10000 + "per year ");


                Console.WriteLine($"\nThe dayscholar  paid {transport_fees} & remaining fee is {rem1_fee}");
                Console.WriteLine();
            }

        }
        public class Hosteller
        {
            public double hostel_fee;

            public Hosteller(double hostel_fee)
            {

                this.hostel_fee = hostel_fee;


                double rem2_fee = 80000 - hostel_fee;
                Console.WriteLine("\nThe hostel  fee: " + 80000 + "per year ");

                Console.WriteLine($"\nThe dayscholar  paid {hostel_fee} & remaining fee is {rem2_fee} ");
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {

            Students students = new Students();
            students.payFee();
            students.displayDetails();
            Console.WriteLine("\nEnter the tranport fee you want to pay: ");
            DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("\n\nEnter the hostel fee you want to pay: ");
            Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
