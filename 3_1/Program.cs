using System;

namespace _3_1
{
    internal class Program
    {
        private static string userString;
        private static int userNumber;

        static void Main()
        {
            Console.WriteLine("Приложение по определению чётного или нечётного числа");

            UserStringInput();
            EvenNumberResult();
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

        static bool IsUserNumberEven() 
        {
            if (userNumber%2==0)
            {
                return true;
            }

            return false;
        }

        static void EvenNumberResult()
        {
            if (IsUserNumberEven())
            {
                Console.WriteLine("Введённое число является чётным");
            }
            else
            {
                Console.WriteLine("Введённое число является нечётным");
            }
        }

    }
}
