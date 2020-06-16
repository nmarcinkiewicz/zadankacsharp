using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace zadankacsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj trzy liczby, każdą wprowadź w nowym wierszu");
            var userInput1 = Console.ReadLine();
            var userInput2 = Console.ReadLine();
            var userInput3 = Console.ReadLine();

            userInput1.Replace(",", ".");
            userInput2.Replace(",", ".");
            userInput3.Replace(",", ".");

            SortedList sortedList = new SortedList();
            if (double.TryParse(userInput1, out double result1))
            {
                sortedList.Add("1", userInput1);
            }

            if (double.TryParse(userInput2, out double result2))
            {
                sortedList.Add("2", userInput2);
            }

            if (double.TryParse(userInput3, out double result3))
            {
                sortedList.Add("3", userInput3);
            }

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.Write("{0}", sortedList);
                Console.ReadKey();
            }
        }
    }
}
