//using System;

//namespace CalculatorLohov
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Калькулятор Нахуй");
//            Console.WriteLine("====================");

//            int a;
//            string aStr = string.Empty;
//            int b;
//            string bStr = string.Empty;

//            Console.WriteLine("Enter the number 1:");

//            aStr = Console.ReadLine();
//            bool res1 = Int32.TryParse(aStr, out a);


//            Console.WriteLine("Enter the number 2:");
//            bStr = Console.ReadLine();

//            bool res2 = Int32.TryParse(aStr, out b);



//            Console.WriteLine("Choose what to do:");

//            char action = Console.ReadLine()[0];

//            switch (action)
//            {
//                case '+':
//                    Console.WriteLine(Sum(a, b));
//                    break;
//                case '-':
//                    Console.WriteLine(Sub(a, b));
//                    break;
//                case '*':
//                    Console.WriteLine(Mul(a, b));
//                    break;
//                case '/':
//                    Console.WriteLine(Div(a, b));
//                    break;
//                default:
//                    break;
//            }

//            Console.ReadKey();




//        }







//        public static int Sum(int a, int b)
//        {
//            return a + b;
//        }

//        public static int Sub(int a, int b)
//        {
//            return a - b;
//        }

//        public static int Mul(int a, int b)
//        {
//            return a * b;
//        }

//        public static int Div(int a, int b)
//        {
//            return a / b;
//        }
//    }
//}

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

            // === ИМЯ (ВВОД/ВЫВОД) ===
            Console.Write("Введи своё имя, пидор: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здарова, {name}! Ща посчитаем, сколько ты стоишь...");

            // === ВОЗРАСТ (УСЛОВИЯ + TRY-PARSE) ===
            Console.Write("Сколько тебе лет, лох? ");
            string ageInput = Console.ReadLine();

            if (!int.TryParse(ageInput, out int age))
            {
                Console.WriteLine("ТЫ ВВЕЛ ХУЙНЮ, ДЕБИЛ! Перезапусти и введи ЧИСЛО.");
                return;
            }

            if (age < 18)
                Console.WriteLine("Ты малолетка, иди учи алгебру, пидор.");
            else if (age > 50)
                Console.WriteLine("Дед, ты уже на пенсии. C# не для тебя.");
            else
                Console.WriteLine($"Ок, {name}, {age} — норм. Можем кодить.");

            // === ОСНОВНОЙ ЦИКЛ КАЛЬКУЛЯТОРА (ЦИКЛЫ + SWITCH) ===
            while (true)
            {
                Console.Clear();
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

                if (choice == "6")
                {
                    Console.WriteLine("Пошёл нахуй, до завтра! Кодь или сдохни.");
                    break;
                }

                if (!"12345".Contains(choice))
                {
                    Console.WriteLine("ВЫБЕРИ ОТ 1 ДО 5, ДЕБИЛ!");
                    Pause();
                    continue;
                }

                double a = ReadNumber("Первое число: ");
                if (double.IsNaN(a)) continue;

                double b = ReadNumber("Второе число: ");
                if (double.IsNaN(b)) continue;

                double result = choice switch
                {
                    "1" => a + b,
                    "2" => a - b,
                    "3" => a * b,
                    "4" => b != 0 ? a / b : double.NaN,
                    "5" => Math.Pow(a, b),
                    _ => double.NaN
                };

                if (double.IsNaN(result))
                    Console.WriteLine("ОШИБКА: ДЕЛЕНИЕ НА НОЛЬ, ЛОХ!");
                else
                    Console.WriteLine($"РЕЗУЛЬТАТ: {a} {GetOperator(choice)} {b} = {result}");

                Pause();
            }
        }

        static double ReadNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                    return number;
                else
                    Console.WriteLine("ВВЕДИ ЧИСЛО, А НЕ ХУЙНЮ! Повтори.");
            }
        }

        static string GetOperator(string choice) => choice switch
        {
            "1" => "+",
            "2" => "-",
            "3" => "*",
            "4" => "/",
            "5" => "^",
            _ => "?"
        };

        static void Pause()
        {
            Console.WriteLine("\nНажми любую клавишу...");
            Console.ReadKey();
        }
    }
}