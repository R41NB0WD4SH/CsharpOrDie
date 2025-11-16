using System;

namespace CalculatorLohov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор Нахуй");
            Console.WriteLine("====================");

            int a;
            string aStr = string.Empty;
            int b;
            string bStr = string.Empty;

            Console.WriteLine("Enter the number 1:");

            aStr = Console.ReadLine();
            bool res1 = Int32.TryParse(aStr, out a);


            Console.WriteLine("Enter the number 2:");
            bStr = Console.ReadLine();

            bool res2 = Int32.TryParse(aStr, out b);



            Console.WriteLine("Choose what to do:");

            char action = Console.ReadLine()[0];

            switch (action)
            {
                case '+':
                    Console.WriteLine(Sum(a, b));
                    break;
                case '-':
                    Console.WriteLine(Sub(a, b));
                    break;
                case '*':
                    Console.WriteLine(Mul(a, b));
                    break;
                case '/':
                    Console.WriteLine(Div(a, b));
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }







        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}