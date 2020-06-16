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
            int userInputYear;
            Console.WriteLine("wprowadź rok w formacie YYYY");
            userInputYear = Convert.ToInt32(Console.ReadLine());

            var conditionParam1 = userInputYear % 400 == 0;
            var conditionParam2 = userInputYear % 100 == 0;
            var conditionParam3 = userInputYear % 4 == 0;

            if ( conditionParam3 && ( conditionParam1  || !conditionParam2 ))
            {
                Console.WriteLine("{0} rok jest rokiem przestępnym", userInputYear);
            }
            else
            {
                Console.WriteLine("{0} nie jest rokiem przestępnym", userInputYear);
            }

            Console.ReadLine();
        }
    }
}
