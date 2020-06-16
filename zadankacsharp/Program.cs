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
            //Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok
            //przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100(za wyjątkiem lat podzielnych
            //przez 400).//

            int userInputYear;
            Console.WriteLine("wprowadź rok w formacie YYYY");
            userInputYear = Convert.ToInt32(Console.ReadLine());

            var a = userInputYear % 400 == 0;
            var b = userInputYear % 100 == 0;
            var c = userInputYear % 4 == 0;

            if ( c && ( a  || !b ))
            {
                Console.WriteLine("jest przestępny");
            }
            else
            {
                Console.WriteLine("NIE JEST przestępny");
            }

            //if (userInputYear % 4 == 0)
            //{
            //    if ((userInputYear % 100 == 0 ^ userInputYear % 400 == 0))
            //    {
            //            Console.WriteLine("{0} nie jest rokiem przestępnym", userInputYear);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} rok jest rokiem przestępnym", userInputYear);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("{0} nie jest rokiem przestępnym", userInputYear);
            //}
          
            Console.ReadLine();
        }
    }
}
