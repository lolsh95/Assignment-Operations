using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp, Var1 = 7, Var2 = 2;

            Var1 /= ++Var2; //الناتج 7.333 السبب ان  ++Var2 ==صار 3
            Console.Write("The Result is = {0} The Scend Reuslt = {1}", Var1,Var2);
            Console.ReadKey();
        }
    }
}
