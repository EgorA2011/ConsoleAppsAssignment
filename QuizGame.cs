using System;

class QuizGame
{
    static void Main(string[] args)
    {
        string[] questions = {
            "Какого цвета у флага Украины?",
            "В каком городе находится ДТЕУ?"
        };
        string[][] options = {
            new string[] { "1. Желтый и голубой", "2. Красный и зеленый", "3. Черный и желтый", "4. Зеленый и фиолетовый" },
            new string[] { "1. Винница", "2. Киев", "3. Львов", "4. Одесса" }
        };
        int[] answers = { 1, 2 }; // правильные ответы
        int score = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Вопрос {i + 1}: {questions[i]}");
            foreach (var option in options[i])
            {
                Console.WriteLine(option);
            }

            Console.Write("Введите номер вашего ответа: ");
            int userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer == answers[i])
            {
                Console.WriteLine("Правильный ответ!");
                score += 100;
            }
            else
            {
                Console.WriteLine("Неправильный ответ.");
                break;
            }
            Console.WriteLine($"Текущий счет: {score}");
        }
    }
}
