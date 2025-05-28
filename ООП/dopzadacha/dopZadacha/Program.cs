using System;

namespace dopZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текущую зарплату Z (в рублях): ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите текущий курс доллара B (руб./долл.): ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент падения курса доллара q (%): ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент роста зарплаты p (%): ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nДолларовый эквивалент зарплаты на следующие 6 месяцев:");

            for (int month = 1; month <= 6; month++)
            {
                B = B * (1 - q / 100);

                R = R * (1 + p / 100);

                double dollarEquivalent = R / B;

                Console.WriteLine($"Месяц {month}: {dollarEquivalent:F2} долларов");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}