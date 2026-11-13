using System;
using System.Text;

namespace Task3oop
{
    class Question
    {
        public string Text { get; }
        public string[] Options { get; }
        public int CorrectNumber { get; }

        public Question(string text, string[] options, int correctNumber)
        {
            Text = text;
            Options = options;
            CorrectNumber = correctNumber;
        }
    }

    class Program
    {
        static int ReadAnswer()
        {
            int answer;
            Console.Write("Ваша відповідь: ");
            while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 4)
            {
                Console.Write("Введіть число від 1 до 4: ");
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Question[] questions = new Question[]
            {
                new Question("Яка планета Сонячної системи найбільша?",
                    new string[] { "Марс", "Юпітер", "Земля", "Сатурн" }, 2),
                new Question("Хто є автором збірки \"Кобзар\"?",
                    new string[] { "Іван Франко", "Леся Українка", "Тарас Шевченко", "Григорій Сковорода" }, 3),
                new Question("Скільки областей нараховується в Україні? (станом на 1991 рік)",
                    new string[] { "24", "21", "26", "19" }, 1),
                new Question("Яка найвища гора в Україні?",
                    new string[] { "Піп Іван", "Хом'як", "Петрос", "Говерла" }, 4),
                new Question("В якому році Україна здобула незалежність?",
                    new string[] { "1990", "1999", "1991", "1992" }, 3)
            };

            const int pointsPerAnswer = 100;
            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Question q = questions[i];

                Console.WriteLine("Current User Score: " + score);
                Console.WriteLine($"Питання {i + 1}, {q.Text}");
                for (int j = 0; j < q.Options.Length; j++)
                {
                    Console.WriteLine($"{j + 1}.{q.Options[j]}");
                }

                int answer = ReadAnswer();

                if (answer == q.CorrectNumber)
                {
                    score += pointsPerAnswer;
                    Console.WriteLine("Correct answer");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    Console.WriteLine("кінець програми.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("Current User Score: " + score);
            Console.WriteLine("Вітаємо, ви відповіли на всі питання!");
            Console.ReadLine();
        }
    }
}
