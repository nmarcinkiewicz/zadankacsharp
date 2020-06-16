using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zadankacsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberEntered1, numberEntered2;
            
            ShowInstructionToUser();
            numberEntered1 = ReadUserInput();
            ShowInstructionToUser();
            numberEntered2 = ReadUserInput();

            VerifyDevisor(numberEntered1,numberEntered2);
            Console.ReadKey();
        }

        private static void ShowInstructionToUser()

        {
            Console.WriteLine("Podaj liczbę");
        }
        private static int ReadUserInput()
        {
            int userInput;
            userInput = Convert.ToInt32(Console.ReadLine());

            return userInput;
        }

        private static void VerifyDevisor(int firstNumber,int secondNumber)
        {
            if (firstNumber % (double)secondNumber == 0)
            {
                Console.WriteLine("Wprowadzona liczba {0} jest dzielnikiem liczby {1}", secondNumber,firstNumber);
            } 
            else
            {
                Console.WriteLine("Wprowadzona liczba {0} NIE jest dzielnikiem liczby {1}", secondNumber,firstNumber);
            }
            return;
        }
        
    }
}
