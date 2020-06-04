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
            Zadanie24();
            Zadanie25();
        }

        private static void Zadanie24()
        {
            int x = 100;
            Console.WriteLine(++x * 2);
            Console.ReadKey(); //202
        }

        private static void Zadanie25()
        {
            int x = 2, y = 3;
            x *= y * 2; // x = x * y * 2 czyli 12
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
