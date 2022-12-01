using System;

namespace _3_2
{
    internal class Program
    {
        private static string userString;
        private static int cardsNumber;
        private static int defaultPicCardsNominal = 10;
        private static int sum;
        private static bool isUserStringCorrect;
        private static int minNumbersCardNominal = 2;
        private static int maxNumbersCardNominal = 100;

        static void Main()
        {
            UserStringInput();
            Scoring();
            ScoreResult();
            Console.ReadLine();
        }

        static void UserStringInput()
        {
            //Перенёс проверку введённой пользователем строки в цикл.
            while (!isUserStringCorrect)
            {
                Console.WriteLine("Вы играете в игру \"21\".\n" +
                        "На данном этапе будет выполнен подсчёт очков." +
                        "\nСколько карт у вас на руках?");

                userString = Console.ReadLine();

                if (int.TryParse(userString, out int result) && result > 0) //Проверка является ли введённая строка корректным числом.
                {
                    cardsNumber = result;
                    isUserStringCorrect = true;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
            }
        }

        static void Scoring()
        {

            for (int i = 1; i <= cardsNumber; i++)
            {
                Console.WriteLine($"Введите номинал карты №{i}");

                string userInput = Console.ReadLine();
                int parsedUserInput;

                // Проверка ввёл ли пользователь число.
                if (int.TryParse(userInput, out parsedUserInput))

                {
                    // Пользователь ввёл число, продолжаем работу с parsedUserInput. Входит ли число в диапазон возможных карт.
                    if (parsedUserInput >= minNumbersCardNominal && parsedUserInput <= maxNumbersCardNominal)
                    {
                        isUserStringCorrect = true;
                        sum += parsedUserInput;
                    }
                    else
                    {
                        isUserStringCorrect = false;
                    }
                }

                else

                {
                    // Пользователь ввёл не число, это картинка или неверная карта.
                    switch (userInput)
                    {
                        case "J":
                        case "j":
                        case "Q":
                        case "q":
                        case "K":
                        case "k":
                        case "T":
                        case "t":
                            sum += defaultPicCardsNominal;
                            isUserStringCorrect = true;
                            break;
                        default:
                            isUserStringCorrect = false;
                            break;
                    }
                }

                if (!isUserStringCorrect)
                {
                    Console.WriteLine("Вы ввели некорректные данные! Попробуйте снова.");
                    i = 0;
                    sum = 0;
                }
            }
        }

        static void ScoreResult()
        {
            Console.WriteLine($"Сумма ваших очков: {sum}");
        }
    }
}
