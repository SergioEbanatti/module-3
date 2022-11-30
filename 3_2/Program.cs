﻿using System;

namespace _3_2
{
    internal class Program
    {
        static string userString;
        static int cardsNumber;
        static int defaultPicCardsNominal = 10;
        static int sum;

        static void Main()
        {
            UserStringInput();
            Scoring();
            Console.ReadLine();
        }

        static void UserStringInput()
        {
            Console.WriteLine("Вы играете в игру \"21\".\n" +
                "На данном этапе будет выполнен подсчёт очков." +
                "\nСколько карт у вас на руках?");

            userString = Console.ReadLine();
            UserStringCheck();
        }

        static void UserStringCheck()
        {
            if (int.TryParse(userString, out int result) && result > 0)
            {
                cardsNumber = result;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректные данные!");
                UserStringInput();
            }
        }

        static void Scoring()
        {
            for (int i = 1; i <= cardsNumber; i++)
            {
                Console.WriteLine($"Введите номинал карты №{i}");
                var nominal = Console.ReadLine();

                switch (nominal)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        sum += int.Parse(nominal);
                        break;
                    case "J":
                    case "j":
                    case "Q":
                    case "q":
                    case "K":
                    case "k":
                    case "T":
                    case "t":
                        sum += defaultPicCardsNominal;
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректные данные! Попробуйте снова.");
                        i = 0;
                        sum = 0;
                        break;
                }
            }

            Console.WriteLine($"Сумма ваших очков: {sum}");
        }
    }
}