using System;
using System.Net;


namespace Tumakov3
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();

            Console.WriteLine("Введите что-нибудь, чтобы закрыть консоль");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод выводит число и месяц по порядковому номеру дня
        /// Входные данные: номер дня (int), високосный год (bool)
        /// </summary>
        /// <returns> - </returns>
        static void Day(int day, bool leapYear = false)
        {
            int month = -1;
            int[] monthsDays = { 31, leapYear == true ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int monthCount = 0; monthCount < 12; monthCount++)
            {
                if (day - monthsDays[monthCount] > 0)
                {
                    day -= monthsDays[monthCount];
                }
                else
                {
                    month = monthCount;
                    break;
                }
            }
            switch (month + 1)
            {
                case 1:
                    Console.WriteLine($"Это {day} января");
                    break;
                case 2:
                    Console.WriteLine($"Это {day} февраля");
                    break;
                case 3:
                    Console.WriteLine($"Это {day} марта");
                    break;
                case 4:
                    Console.WriteLine($"Это {day} апреля");
                    break;
                case 5:
                    Console.WriteLine($"Это {day} мая");
                    break;
                case 6:
                    Console.WriteLine($"Это {day} июня");
                    break;
                case 7:
                    Console.WriteLine($"Это {day} июля");
                    break;
                case 8:
                    Console.WriteLine($"Это {day} августа");
                    break;
                case 9:
                    Console.WriteLine($"Это {day} сентября");
                    break;
                case 10:
                    Console.WriteLine($"Это {day} октября");
                    break;
                case 11:
                    Console.WriteLine($"Это {day} ноября");
                    break;
                case 12:
                    Console.WriteLine($"Это {day} декабря");
                    break;
                default:
                    Console.WriteLine("Нет такого дня");
                    break;
            }
        }

        /// <summary>
        /// Вывести число и месяц по порядковому числу дня без проверки на существование такого дня
        /// </summary>
        /// <returns> - </returns>
        static void Task1()
        {
            Console.WriteLine("Упражнение 4.1\n");
            Console.WriteLine("Введите целое число от 1 до 365 - номер дня в году");
            int dayNum1;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int res))
                {
                    Console.WriteLine("А если прочитать ТЗ?) Снова пробуем");
                }
                else
                {
                    dayNum1 = res;
                    break;
                }
            }
            Day(dayNum1);
        }

        /// <summary>
        /// Вывести число и месяц по порядковому числу дня (1 <-> 365)
        /// </summary>
        /// <returns> - </returns>
        static void Task2()
        {
            Console.WriteLine("Упражнение 4.2\n");
            Console.WriteLine("Введите целое число от 1 до 365 - номер дня в году");
            int dayNum2;

            while (true)
            {
                if (!(int.TryParse(Console.ReadLine(), out int res) & 1 <= res & res <= 365))
                {
                    Console.WriteLine("А если прочитать ТЗ?) Целое от 1 до 365 включительно. Снова");
                }
                else
                {
                    dayNum2 = res;
                    break;
                }
            }
            Day(dayNum2);
        }

        /// <summary>
        /// Вывести число и месяц по порядковому числу дня (1 <-> 365) с учётом високосного года
        /// </summary>
        /// <returns> - </returns>
        static void Task3()
        {
            Console.WriteLine("Упражнение 4.2\n");
            Console.WriteLine("Введите год");
            int year;
            while (true)
            {
                if (!(int.TryParse(Console.ReadLine(), out int resYear) & 0 <= resYear))
                {
                    Console.WriteLine("Я понимаю, что технически такой год был/будет. Но можно в реальность вернуться? Спасибо. Заново");
                }
                else
                {
                    year = resYear;
                    break;
                }
            }
            bool isLeap;
            if (year % 400 == 0)
            {
                isLeap = true;
                Console.WriteLine("Год високосный");
            }
            else if (year % 100 == 0)
            {
                isLeap = false;
                Console.WriteLine("Год невисокосный");
            }
            else if (year % 4 == 0)
            {
                isLeap = true;
                Console.WriteLine("Год високосный");
            }
            else
            {
                isLeap = false;
                Console.WriteLine("Год невисокосный");
            }
            Console.WriteLine($"Введите номер дня в году");
            int dayNum3;

            while (true)
            {
                if (!(int.TryParse(Console.ReadLine(), out int res) & 1 <= res & (res <= 366 & isLeap) || (res <= 365 & !isLeap)))
                {
                    Console.WriteLine("А если прочитать ТЗ?). Лэт'с гоу эгэйн");
                }
                else
                {
                    dayNum3 = res;
                    break;
                }
            }
            Day(dayNum3, isLeap);
        }
    }
}
