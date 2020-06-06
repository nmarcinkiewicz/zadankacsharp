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
            Zadanie26();
            Zadanie27();
            Zadanie28();
            Zadanie29a();
            Zadanie29b();
            Zadanie29c();
            Zadanie29d();
            Zadanie29e();
            Zadanie29f();
            Console.ReadKey();
        }

        private static void Zadanie24()
        {
            int x = 100;
            Console.WriteLine(++x * 2); // 202 odp.a
        }

        private static void Zadanie25()
        {
            int x = 2, y = 3;
            x *= y * 2; // x = x * y * 2 czyli 12 odp d
            Console.WriteLine(x);
        }

        private static void Zadanie26()
        {
            int x, y = 4;
            x = (y -= 2);
            Console.WriteLine(x); // x= 2; y = y-2 czyli y=2
            x = y++;
            Console.WriteLine(x); //  x = 2; y=3
            x = y--;
            Console.WriteLine(x); // x = 2 ; y=2
        }

        private static void Zadanie27()
        {
            int x, y = 5;
            x = ++y * 2; // x= 12 y=6
            x = y++; // x=6 y=7
            x = --y; // x=6 y=6
            Console.WriteLine(++y); // y=7
        }
    
        private static void Zadanie28()
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x); // true odp. a 
        }

        private static void Zadanie29a()
        {
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);  //wynik=False x=2 y=4 z=2
        }

        private static void Zadanie29b()
        {
            int x=1, y=4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("Wynik ={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik= False x=2 y=5 z=2
        }

        private static void Zadanie29c()
        {
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("Wynik ={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik = false, x=2, y=5, z=1
        }

        private static void Zadanie29d()
        {
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ >2 || ++z > 0);
            Console.WriteLine("Wynik ={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik=true, x=1, y=3, z=4
        }

        private static void Zadanie29e()
        {
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("Wynik ={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik=true, x=1, y=4, z=4
        }

        private static void Zadanie29f()
        {
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("Wynik ={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik=true, x=1, y=4, z=5
        }
    }
}
