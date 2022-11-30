using System;

namespace _3_4
{
    internal class Program
    {
        private static string userString;
        private static int sequenceLenght;
        private static int minNumber = int.MaxValue;

        static void Main()
        {
            Console.WriteLine("Наименьший элемент в последовательности");

            UserStringInput();
            UserInputNumbers();
            SequenceMinNumberResult();
            Console.ReadLine();
        }

        static void UserStringInput()
        {
            Console.WriteLine("Задайте длинну вашей последовательности чисел");
            userString = Console.ReadLine();
            UserStringCheck();
        }

        static void UserStringCheck()
        {
            if (int.TryParse(userString, out int result) && result > 1)
            {
                sequenceLenght = result;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректные данные!");
                UserStringInput();
            }
        }

        static void UserInputNumbers()
        {
            for (int i = 1; i <= sequenceLenght; i++)
            {
                Console.WriteLine($"Введите число №{i} вашей последовательности");
                userString = Console.ReadLine();

                if (int.TryParse(userString, out int currentNumber))
                {
                    if (currentNumber < minNumber)
                    {
                        minNumber = currentNumber;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные! Попробуйте снова.");
                    i = 0;
                    minNumber = int.MaxValue;
                }
            }
        }

        static void SequenceMinNumberResult()
        {
            Console.WriteLine($"Наименьший элемент вашей последовательности: {minNumber}");
        }

    }
}
