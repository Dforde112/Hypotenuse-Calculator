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
            //Welcome user to the Hypotenuse Calculator
            Console.Writeline("Welcome to the Hypotenuse Calculator!");
            
            //Prompt user to enter Side A
            Console.WriteLine("Enter side a");
            double a = Convert.ToDouble(Console.ReadLine());

            //Prompt user to enter Side B
            Console.WriteLine("Enter side b");
            double b= Convert.ToDouble(Console.ReadLine());

            //Perform Calculation on given information
            double c = Math.Sqrt((a * a) + (b * b));

            //Print answer to console
            Console.WriteLine("the hypotenuse is " + c);

            Console.ReadKey();
        }
    }
}
