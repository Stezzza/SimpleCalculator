using System;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool add = false, subtract = false, multiply = false, divide = false;

            Console.WriteLine("========");
            Console.WriteLine("Welcome to calculator");
            Console.WriteLine("========\n");

            Console.WriteLine("Pick number one");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick the Function: A (Add), S (Subtract), M (Multiply), D (Divide)");

            // Capture the key press once
            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.A)
            {
                add = true;
            }
            else if (key == ConsoleKey.S)
            {
                subtract = true;
            }
            else if (key == ConsoleKey.M)
            {
                multiply = true;
            }
            else if (key == ConsoleKey.D)
            {
                divide = true;
            }

            Console.WriteLine("\nEnter number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press spacebar to solve");
            if ((number1 == 0 && number2 == 0) && (divide || multiply))
            {
                Console.WriteLine("cannot multiply or divide zero by zero");
                return;
            }
            
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                if (add)
                {
                    Console.WriteLine(number1 + number2);
                }
                if (subtract)
                {
                    Console.WriteLine(number1 - number2);
                }
                if (multiply)
                {
                    Console.WriteLine(number1 * number2);
                }
                if (divide)
                {
                    Console.WriteLine(number1 / number2);
                }
            }
        }
    }
}
