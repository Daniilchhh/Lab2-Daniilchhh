using System;
using System.Text;

namespace Task2oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int height;
            Console.Write("Введіть висоту трикутника: ");
            while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.Write("Некоректне значення. Введіть додатне ціле число: ");
            }

            for (int row = 1; row <= height; row++)
            {
                Console.Write(new string(' ', height - row));

                for (int k = 0; k < row; k++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
