using System;

namespace Чугунов
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите переменную A (1+A+A^2+A^3+...+A^N)");
            double number_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную N (1+A+A^2+A^3+...+A^N)");
            double number_n = double.Parse(Console.ReadLine());
            Console.WriteLine("Для начала работы программы нажмите любую клавишу");
            Console.ReadKey(true);
            double number_i = 0;
            double number_j = 0;
            double answer = 1;
            while (number_i != number_n)
            {
                number_i++;
                number_j = Math.Pow(number_a, number_i);
                answer = answer + number_j;
            }

            Console.WriteLine("Ответ: {0} ", answer);
            Console.ReadKey();
        }
    }
}
