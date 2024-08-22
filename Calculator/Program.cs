using System;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                bool add = false, subtract = false, multiply = false, divide = false;
                bool validOperation = false;

                Console.WriteLine("========");
                Console.WriteLine("Welcome to calculator");
                Console.WriteLine("========\n");

                int number1 = GetValidNumber("Pick number one");

                while (!validOperation)
                {
                    Console.WriteLine("Pick the Function: \nA (Add), \nS (Subtract), \nM (Multiply), \nD (Divide)");

                    // Capture the key press once
                    var key = Console.ReadKey().Key;

                    if (key == ConsoleKey.A)
                    {
                        add = true;
                        validOperation = true;
                    }
                    else if (key == ConsoleKey.S)
                    {
                        subtract = true;
                        validOperation = true;
                    }
                    else if (key == ConsoleKey.M)
                    {
                        multiply = true;
                        validOperation = true;
                    }
                    else if (key == ConsoleKey.D)
                    {
                        divide = true;
                        validOperation = true;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid option. Please choose a valid operation.");
                    }
                }

                int number2 = GetValidNumber("Enter number two");

                Console.WriteLine("Press spacebar to solve");
                if ((number1 == 0 && number2 == 0) && (divide || multiply))
                {
                    Console.WriteLine("Cannot multiply or divide zero by zero");
                    return;
                }

                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    if (add)
                    {
                        Console.WriteLine("Result: " + (number1 + number2));
                    }
                    if (subtract)
                    {
                        Console.WriteLine("Result: " + (number1 - number2));
                    }
                    if (multiply)
                    {
                        Console.WriteLine("Result: " + (number1 * number2));
                    }
                    if (divide)
                    {
                        Console.WriteLine("Result: " + (number1 / number2));
                    }
                }

                Console.Write("Want to play again? Y/N: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    playAgain = true;
                    Console.WriteLine();  // To add a new line after pressing 'Y'
                }
                else
                {
                    playAgain = false;
                }
            }
        }

        // Method to get a valid number from the user
        static int GetValidNumber(string prompt)
        {
            int number;
            bool isValid;

            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out number);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (!isValid);

            return number;
        }
    }
}
