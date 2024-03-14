using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projec_Day1
{
    internal class Program1
    {
        static void Main()
        {
            // Add 2 numbers
            int num1 = 10, num2 = 20;
            Console.WriteLine(num1 + num2);
            Console.WriteLine("Sum of num1 & num2 is " + (num1+num2));
            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, (num1+num2));
            Console.WriteLine($"Sum of {num1} and {num2} is {num1+num2}");


        }
    }
}
