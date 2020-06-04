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
            decimal weight, height, bmi;
     
            Console.WriteLine("Podaj swoją wagę [kg]");
            weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Podaj swój wzrost [m]");
            height = decimal.Parse(Console.ReadLine());

            bmi = weight / (height * height);
            Console.WriteLine("Twoje BMI wynosi {0:F2}",bmi);
            Console.ReadKey();




          


        }
    }
}
