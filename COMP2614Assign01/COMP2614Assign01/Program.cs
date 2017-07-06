using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumber = 0;    //Sum of number
            int totalSquared = 0;   //Sum of squared
            int totalCubed = 0;     //Sum of cubed

            Console.WriteLine("{0, 10} {1, 10} {2, 10}", "number", "square", "cube");
            Console.WriteLine("--------------------------------");

            //Main calculation and print to console
            for (int i=0; i<=20; i+=2)
            {
                Console.WriteLine("{0, 10} {1, 10} {2, 10:n0}", i, i*i, i*i*i);
                totalNumber += i;
                totalSquared += i * i;
                totalCubed += i * i * i;
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("{0, 10} {1, 10:n0} {2, 10:n0}", totalNumber, totalSquared, totalCubed);
        }
    }
}
