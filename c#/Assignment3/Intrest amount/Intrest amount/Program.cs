using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrest_amount
{
    internal class Intrest_amount
    {
        double rate;
       main ()
       public void loanCalculator(double loanamount)
        {
            Console.WriteLine("Enter rate of intrest");
            rate = Convert.ToDouble(Console.ReadLine());
            double intrest = (loanamount * rate) / 100;
            Console.WriteLine("Rate of intrest for " + rate + "% is :" + intrest);
        }
    }
}
