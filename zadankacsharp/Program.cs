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

            if (userInputYear % 4 == 0)
            {
                if (!(userInputYear % 100 == 0))
                {
                    if (userInputYear % 400 ==0)
                    {
                        Console.WriteLine("Podany {0} rok jest rokiem przestępnym", userInputYear);
                    }
                }
            }
            Console.WriteLine("{0} nie jest rokiem przestępnym", userInputYear);
            Console.ReadLine();
        }
    }
}
