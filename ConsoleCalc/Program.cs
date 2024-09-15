using System;
using System.Text;

class Calculator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Калькулятор:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите операцию (1/2/3/4/5): ");

            // проверяем коректность ввода нужной операции

            bool resultinput = int.TryParse(Console.ReadLine(), out int result);
            if (resultinput == false)
            {
                while (!resultinput || result <= 0 || result >= 6)
                {
                    Console.Write("Данные некорретны. Введите числовое значение от 1 до 5: ");
                    resultinput = int.TryParse(Console.ReadLine(), out result);
                }
            }
            else
            {
                while (!resultinput || result <= 0 || result >= 6)
                {
                    Console.Write("Данные некорретны. Введите число от 1 до 5: ");
                    resultinput = int.TryParse(Console.ReadLine(), out result);
                }
            }

                if (result == 5)
                {
                    return;
                }
            


            // Получаем от пользователя первое число

            bool firstinput = false, secondinput = false;
            double firstnumber = 0;
            double secondnumber = 0;

            while (!firstinput)
            {
            Console.Write("Введите первое число: ");
            firstinput = double.TryParse(Console.ReadLine(), out firstnumber);
            if (firstinput == false)
            {
                Console.WriteLine("Первое число введено некорректно. Введите числовое значение. Если число дробное, используйте запятую");
            }
            }

            // Получаем от пользователя второе число

            while (!secondinput)
            {
            Console.Write("Введите второе число: ");
            secondinput = double.TryParse(Console.ReadLine(), out secondnumber);
            if (secondinput == false)
            {
                Console.WriteLine("Второе число введено некорректно.Введите числовое значение. Если число дробное, используйте запятую");
            }
            }

            //Проводим операцию на полученными числами

            switch (result)
            {
                case 1: Console.WriteLine($"Результат сложение: {firstnumber + secondnumber}"); break;
                case 2: Console.WriteLine($"Результат вычитания: {firstnumber - secondnumber}"); break;
                case 3: Console.WriteLine($"Результат умножения: {firstnumber * secondnumber}"); break;
                case 4:
                    if (secondnumber != 0)
                    {
                        Console.WriteLine($"Результат деления: {firstnumber / secondnumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Деление на ноль неовозможно");
                    }
                    break;
               

            }

        }
    }
}