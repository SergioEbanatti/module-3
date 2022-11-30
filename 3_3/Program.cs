using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Program
    {
        private static string userString;
        private static int userNumber;
        private static bool isNumberPrime = true;

        static void Main(string[] args)
        {
            UserStringInput();
            PrimeNumberCheck();
            PrimeNumberResult();
            Console.ReadLine();
        }

        static void UserStringInput()
        {
            Console.WriteLine("Введите целое число");
            userString = Console.ReadLine();
            UserStringCheck();
        }

        static void UserStringCheck()
        {
            if (int.TryParse(userString, out int result))
            {
                userNumber = result;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректные данные!");
                UserStringInput();
            }
        }

        static void PrimeNumberCheck()
        {
            int i = 2;

            while (i < userNumber)
            {
                if (userNumber % i == 0)
                {
                    isNumberPrime = false;
                    break;
                }

                i++;
            }
        }

        static void PrimeNumberResult()
        {
            if (isNumberPrime && userNumber > 1)
            {
                Console.WriteLine("Число является простым");
            }
            else
            {
                Console.WriteLine("Число не является простым");
            }
        }
    }
}
