using System;
using System.Text;

namespace Task1oop
{
    class Program
    {
        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int year;
            Console.Write("Введіть рік: ");
            while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
            {
                Console.Write("Некоректне значення. Введіть додатне ціле число: ");
            }

            if (IsLeapYear(year))
                Console.WriteLine($"{year} рік — високосний");
            else
                Console.WriteLine($"{year} рік — не високосний");

            Console.ReadLine();
        }
    }
}
