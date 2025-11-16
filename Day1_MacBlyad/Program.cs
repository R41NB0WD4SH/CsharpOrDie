using System;

namespace CalculatorLohov
{
    class Program
    {
        static void Main()
        {
            // === КРАСНЫЙ ТЕКСТ, ЧТОБ ТЫ НЕ СПАЛ ===
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ЭВРУБАЙ ГРОМКОСТЬ, СУКА! КАЛЬКУЛЯТОР ДЛЯ ЛОХОВ v1.0");
            Console.ResetColor();

            // === ИМЯ ===
            Console.Write("Введи своё имя, пидор: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здарова, {name}! Ща посчитаем, сколько ты стоишь...");

            // === ВОЗРАСТ ===
            Console.Write("Сколько тебе лет, лох? ");
            string ageInput = Console.ReadLine();

            // ПРОВЕРКА: ЧИСЛО ЛИ ЭТО?
            if (!int.TryParse(ageInput, out int age))
            {
                Console.WriteLine("ТЫ ВВЕЛ ХУЙНЮ, ДЕБИЛ! Перезапусти и введи ЧИСЛО.");
                return; // ВЫХОД ИЗ ПРОГРАММЫ
            }

            if (age < 18)
                Console.WriteLine("Ты малолетка, иди учи алгебру, пидор.");
            else if (age > 50)
                Console.WriteLine("Дед, ты уже на пенсии. C# не для тебя.");
            else
                Console.WriteLine($"Ок, {name}, {age} — норм. Можем кодить.");

            // === ОСНОВНОЙ ЦИКЛ КАЛЬКУЛЯТОРА ===
            while (true)
            {
                Console.Clear(); // ОЧИЩАЕМ ЭКРАН
                Console.WriteLine("==================================");
                Console.WriteLine("     КАЛЬКУЛЯТОР ДЛЯ ЛОХОВ");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Сложение (+)");
                Console.WriteLine("2. Вычитание (-)");
                Console.WriteLine("3. Умножение (*)");
                Console.WriteLine("4. Деление (/)");
                Console.WriteLine("5. Возведение в степень (^)");
                Console.WriteLine("6. Выйти");
                Console.WriteLine("----------------------------------");
                Console.Write("Выбирай, ниггер (1-6): ");

                string choice = Console.ReadLine();

                // ВЫХОД
                if (choice == "6")
                {
                    Console.WriteLine("Пошёл нахуй, до завтра! Кодь или сдохни.");
                    break;
                }

                // ПРОВЕРКА: ТОЛЬКО 1-5
                if (!"12345".Contains(choice))
                {
                    Console.WriteLine("ВЫБЕРИ ОТ 1 ДО 5, ДЕБИЛ!");
                    Pause();
                    continue;
                }

                // ВВОД ЧИСЕЛ С TRY-CATCH (ЭТО ТВОЯ СТРАХОВКА)
                double a = ReadNumber("Первое число: ");
                if (double.IsNaN(a)) continue;

                double b = ReadNumber("Второе число: ");
                if (double.IsNaN(b)) continue;

                // РАСЧЁТ
                double result = choice switch
                {
                    "1" => a + b,
                    "2" => a - b,
                    "3" => a * b,
                    "4" => b != 0 ? a / b : double.NaN,
                    "5" => Math.Pow(a, b),
                    _ => double.NaN
                };

                // ВЫВОД
                if (double.IsNaN(result))
                    Console.WriteLine("ОШИБКА: ДЕЛЕНИЕ НА НОЛЬ, ЛОХ!");
                else
                    Console.WriteLine($"РЕЗУЛЬТАТ: {a} {GetOperator(choice)} {b} = {result}");

                Pause();
            }
        }

        // === МЕТОД ДЛЯ ВВОДА ЧИСЛА (С TRY-CATCH) ===
        static double ReadNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                // ЭТО И ЕСТЬ TRY-CATCH, СУКА!
                if (double.TryParse(input, out double number))
                    return number;
                else
                    Console.WriteLine("ВВЕДИ ЧИСЛО, А НЕ ХУЙНЮ! Повтори.");
            }
        }

        // === ОПЕРАТОР ДЛЯ КРАСОТЫ ===
        static string GetOperator(string choice) => choice switch
        {
            "1" => "+",
            "2" => "-",
            "3" => "*",
            "4" => "/",
            "5" => "^",
            _ => "?"
        };

        // === ПАУЗА ДО НАЖАТИЯ КЛАВИШИ ===
        static void Pause()
        {
            Console.WriteLine("\nНажми любую клавишу, чтоб продолжить...");
            Console.ReadKey();
        }
    }
}