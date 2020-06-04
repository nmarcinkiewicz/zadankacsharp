using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadankacsharp
{
    class Program
    {
         static void Main(string[] args)
        {
            double a, b, c;
            double delta;

            a = ReadParameter("a");
            b = ReadParameter("b");
            c = ReadParameter("c");

            delta = (b * b) - (4 * (a * c));
            Console.WriteLine(delta);
            Console.ReadLine();
        }

        private static double ReadParameter(string parameter)
        {
            Console.WriteLine("Podaj współczynnik równania " + parameter);
            
            return double.Parse(Console.ReadLine());
        }
    }
}
