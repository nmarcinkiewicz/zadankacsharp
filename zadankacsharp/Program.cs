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
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();
        }
    }
}
