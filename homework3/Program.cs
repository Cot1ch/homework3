using System;


namespace homework3
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

            Console.WriteLine("Нажмите что-нибудь для выхода из этого кринжа");
            Console.ReadKey();
        }
        static double[] EnterArray()
        {
            string[] array;
            double[] nums = new double[10];
            bool flag = true;

            do
            {
                Console.WriteLine("Введите через пробел последовательность из 10 чисел");
                array = Console.ReadLine().Split();
                if (array.Length != 10)
                {
                    Console.WriteLine("Нужен массив из 10 чисел");
                }
                else
                {
                    bool flag2 = true;
                    for (int i = 0; i < 10; i++)
                    {
                        if (!double.TryParse(array[i], out double num))
                        {
                            Console.WriteLine($"Ошибка в числе {array[i]} - оно не число:)");
                            flag2 = false;
                            break;
                        }
                        else
                        {
                            nums[i] = num;
                        }
                    }
                    if (flag2)
                    {
                        flag = false;
                    }
                }
            }
            while (flag);
            return nums;
        }

        static void Task1()
        {
            //
            //
            //
            Console.WriteLine("1 задание\n");

            double[] nums = EnterArray();

            for (int i = 0; i < 9; i++)
            {
                if (nums[i] >= nums[i + 1])
                {
                    Console.WriteLine($"На {i + 1} элементе возрастание последовательности нарушается");
                    return;
                }
            }
            Console.WriteLine("Последовательность упорядочена по возрастанию");
        }

        static void Task2()
        {
            //
            //
            //
            Console.WriteLine("2 задание\n");
            try
            {
                Console.WriteLine("Введите номер карты - число от 6 до 14");

                int cardNum = int.Parse(Console.ReadLine());
                while (6 > cardNum || 14 < cardNum)
                {
                    Console.WriteLine("От 6 до 14 включительно!!!!!!!!\nВведите вновь");
                    cardNum = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Эта карта - {(Cards)cardNum}!");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Это не целое число!");
            }
            finally
            {
                Console.WriteLine("Спасибо за уделённое время");
            }

        }
        static void Task3()
        {
            //
            //
            //
            Console.WriteLine("3 задание\n");

            Console.WriteLine("Скажи мне, кто ты, и я скажу, чем садить печень");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }
        static void Task4()
        {
            //
            //
            //
            Console.WriteLine("4 задание\n");

            Console.WriteLine("Введите порядковый номер дня недели (1 - 7)");
            string smth;
            while (true)
            {
                smth = Console.ReadLine();
                if (!byte.TryParse(smth, out byte dayNumber))
                {
                    Console.WriteLine("Ну такого дня точно нет, давай по новой");
                }
                else if (1 > dayNumber || 7 < dayNumber)
                {
                    Console.WriteLine("Нет такого дня недели, заново давай");
                }
                else
                {
                    Console.WriteLine($"{dayNumber} день недели - {(Week)dayNumber}");
                    break;
                }
            }

        }
        static void Task5()
        {
            //
            //
            //
            Console.WriteLine("5 задание\n");

            // string[] dolls = {"Hello Kitty", "Teddy Bear", "Mr. Monopoly", "Hello Kitty", "Barbie doll"}
            Console.WriteLine("Введите в одной строке через нижнее подчёркивание игрушки");
            Console.WriteLine("Пр.: Hello Kitty_Mr. Monopoly");

            int bag = 0;
            foreach (string doll in Console.ReadLine().Split('_')) //Либо foreach (string doll in dolls)
            {
                if (doll.ToLower() == "hello kitty" || doll.ToLower() == "barbie doll")
                {
                    bag++;
                }
            }
            Console.WriteLine($"Кукол в сумке = {bag}");
        }
        public enum Cards
        {
            Шестёрка = 6,
            Семёрка = 7,
            Восьмёрка = 8,
            Девяточка = 9,
            Десятка = 10,
            Валет = 11,
            Дама = 12,
            Король = 13,
            Туз = 14
        }
        public enum Week
        {
            понедельник = 1,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресенье
        }
    }
}
