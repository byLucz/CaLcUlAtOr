using System;

namespace cal4ik
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Первое число");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Менюшка");
            Console.WriteLine("\t+ - плюс");
            Console.WriteLine("\t- - минус");
            Console.WriteLine("\t* - умножение");
            Console.WriteLine("\t/ - деление");
            Console.Write("Твой выбор?");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Ваш результат: {num1} + {num2} = " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine($"Ваш результат: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine($"Ваш результат: {num1} * {num2} = " + (num1 * num2));
                    break;

                case "/":
                    Console.WriteLine($"Ваш результат: {num1} / {num2} = " + (num1 / num2));
                    break;

            }
        }
    }
}
