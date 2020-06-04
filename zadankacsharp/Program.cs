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
            double c, f;
            Console.WriteLine("Podaj temperaturę w stopniach Celsjusza");
            c = double.Parse(Console.ReadLine());
            f = 32 + 9 / 5 * c;
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
