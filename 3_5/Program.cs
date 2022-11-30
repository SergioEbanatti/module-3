using System;

namespace _3_5
{
    internal class Program
    {
        private static string userString;
        private static int maxRangeValue;
        private static int hiddenNumber;
        private static int userNumber;
        private static bool isGameOn = true;

        static void Main()
        {
            Console.WriteLine("Игра \"Угадай число\"");
            UserStringInput();
            HiddenNumberRandomize();
            HiddenNumberCheck();
            HiddenNumberResult();
            Console.ReadLine();
        }

        static void UserStringInput()
        {
            Console.WriteLine($"Минимальное число, которое будет загадано: 0\n" +
                $"Задайте максимальное число, которое может быть загадано");

            userString = Console.ReadLine();

            if (!IsUserStringCorrect(ref maxRangeValue))
            {
                Console.WriteLine("Вы ввели некорректные данные!");
                UserStringInput();
            }
        }

        static bool IsUserStringCorrect(ref int checkingResultNumber)
        {
            if (int.TryParse(userString, out int result) && result >= 0)
            {
                checkingResultNumber = result;
                return true;
            }
            else
            {
                return false;
            }
        }

        static void HiddenNumberRandomize()
        {
            hiddenNumber = new Random().Next(maxRangeValue);
            Console.WriteLine($"Загаданно число от 0 до {maxRangeValue}");
        }

        static void HiddenNumberCheck()
        {
            while (isGameOn)
            {
                Console.WriteLine("Попробуйте угадать число\n" +
                    "Если сдаётесь, просто нажмите \"Enter\"");

                userString = Console.ReadLine();

                if (!IsUserStringCorrect(ref userNumber))
                {
                    switch (userString)
                    {
                        case "":
                            isGameOn = false;
                            break;
                        default:
                            Console.WriteLine("Вы ввели некорректные данные!");
                            break;
                    }
                    continue;
                }

                if (userNumber < hiddenNumber)
                {
                    Console.WriteLine("Ваше число меньше загаданного");
                }
                else if (userNumber > hiddenNumber)
                {
                    Console.WriteLine("Ваше число больше загаданного");
                }
                else
                {
                    Console.WriteLine("Вы угадали!");
                    isGameOn = false;
                }
            }
        }

        static void HiddenNumberResult()
        {
            Console.WriteLine($"Было загаданно число {hiddenNumber}");
        }
    }
}
