using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b");
            double b= Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("the hypotenuse is " + c);

            Console.ReadKey();
        }
    }
}
