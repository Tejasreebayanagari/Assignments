using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class Program
    {
        int carno;
        String carName;
        String carType;
        readonly double carcost = 5000000;

            public cars(int carno,string carName ,String carType)
            {
                this.carno = carno;
                this.carName = carName;
                this.carType = carType;
                Console.WriteLine($"Carno is:{carno},car name is {carName},car Type is{carType},car cost is {carcost}");


            }
            public  Cars(double cost)
            {
                carcost = cost;
                Console.WriteLine("After changing");
            Console.WriteLine($"Carno is:{ carno},car name is { carName },car Type is { carType },car cost is { carcost }");
            }
        public Void displaycarddetais()
                {
                Console.WriteLine("Before Changing");
                Console.WriteLine($"Carno is:{carno},car name is {carName},car Type is{carType},car cost is {carcost}");

                }


        }
    }
}