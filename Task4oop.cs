using System;
using System.Collections.Generic;
using System.Text;

namespace Task4oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть вираз:");
            string text = Console.ReadLine().Replace(" ", "");

            List<double> numbers = new List<double>();
            List<char> signs = new List<char>();
            string current = "";

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    current += c;
                }
                else
                {
                    numbers.Add(double.Parse(current));
                    signs.Add(c);
                    current = "";
                }
            }
            numbers.Add(double.Parse(current));

            int k = 0;
            while (k < signs.Count)
            {
                if (signs[k] == '*')
                {
                    numbers[k] = numbers[k] * numbers[k + 1];
                    numbers.RemoveAt(k + 1);
                    signs.RemoveAt(k);
                }
                else if (signs[k] == '/')
                {
                    numbers[k] = numbers[k] / numbers[k + 1];
                    numbers.RemoveAt(k + 1);
                    signs.RemoveAt(k);
                }
                else
                {
                    k++;
                }
            }
            double result = numbers[0];
            for (int i = 0; i < signs.Count; i++)
            {
                if (signs[i] == '+')
                    result += numbers[i + 1];
                else
                    result -= numbers[i + 1];
            }

            Console.WriteLine("Відповідь: " + result);
            Console.ReadLine();
        }
    }
}
