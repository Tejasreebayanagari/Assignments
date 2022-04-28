using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_a4
{
    internal class Program
    {
        public class Employee
        {
            public int empid;
            public string empname;
            public float empsalary;

            public Employee(int empid, string empname, float empsalary)
            {
                this.empid = empid;
                this.empname = empname;
                this.empsalary = empsalary;
            }
            public void dispDetails()
            {
                Console.WriteLine($"\nName of Employee {empname} with ID {empid} earns salary of {empsalary}");
            }
        }
        public class PartTimeemployee
        {
            public int wages = 2000;

            public void showDetails()
            {
                Console.WriteLine($"Partime employee earns wages " + wages);
            }
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee(24, "Mishra", 17656.866f);
            employee.dispDetails();
            PartTimeemployee ptemployee = new PartTimeemployee();
            ptemployee.showDetails();
            Console.ReadLine();
        }
    }
}
