using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqureRootOfANumber
{
    internal class SqureRootOfANumber
    {
        public static void DisplaySqureRoot()
        {
            Console.Write("Enter a non-negative number: ");
            double c = double.Parse(Console.ReadLine());

            double epsilon = 1e-15;
            double t = c;

            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }

            Console.WriteLine("The square root of {0} is {1}", c, t);
        }
    }
}
