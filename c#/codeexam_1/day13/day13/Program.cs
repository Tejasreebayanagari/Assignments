using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Sample
{
    public int i;
}
class MyProgram
{
    static void Main()
    {
        Sample x = new Sample();
        x.i = 10;
        fun(x);
        Console.Write(x.i + "" );
    }
    static void fun(Sample y)
    {
        y.i = 20;
        Console.Write(y.i + "" );
        Console.ReadKey();
    }
}
    