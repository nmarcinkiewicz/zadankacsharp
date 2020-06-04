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
            //Zadanie24();
            //Zadanie25();
            //Zadanie26();
            Zadanie27();
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

        private static void Zadanie26()
        {
            int x, y = 4;
            x = (y -= 2);
            Console.WriteLine(x);
            x = y++;
            Console.WriteLine(x);  //nie kapuje czemu tutaj jest 2
            x = y--;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    
        private static void Zadanie27()
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x); //true
            Console.ReadKey();
        }
    }
}
