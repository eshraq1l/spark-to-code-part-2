namespace spark_to_code_part_2
{
    internal class task1
    {
        /// <summary>
        /// /////////////////////////////////////////
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter a starting number for the countdown: ");
            int start = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lift off!");
        }
    }
}
///////////////////////////////////////////////////////
///task2 

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Sum from 1 to " + n + " = " + sum);
        }
    }
}
///////////////////////////////////////////////////////////////////////////
///task3 
///

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }
    }
}
/////////////////////////////////////////////////////////////////////
///

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "Spark2026";

            Console.Write("Enter password: ");
            string attempt = Console.ReadLine()!;

            while (attempt != correctPassword)
            {
                Console.WriteLine("Incorrect password, try again");
                Console.Write("Enter password: ");
                attempt = Console.ReadLine()!;
            }

            Console.WriteLine("Access Granted");
        }
    }
}/////////////////////////////////////////////////////////
//task4 


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.Write("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine()!);
                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct! You got it in " + attempts + " attempts.");
                }

            } while (guess != secretNumber);
        }
    }
}/////////////////////////////////////////////////
////Task 6 


namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine()!);

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine()!);

                double result = num1 / num2;

                // note: dividing doubles by 0 gives Infinity instead of throwing,
                // so we check for that manually too
                if (double.IsInfinity(result))
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine("Result: " + result);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid numbers only.");
            }
        }
    }////////////////////////////////////////////////
    /////////////task 7

namespace Task7
    {
        class Program
        {
            static void Main(string[] args)
            {
                bool running = true;

                while (running)
                {
                    Console.WriteLine();
                    Console.WriteLine("----- MENU -----");
                    Console.WriteLine("1) Say Hello");
                    Console.WriteLine("2) Show Greeting");
                    Console.WriteLine("3) Exit");
                    Console.Write("Choose an option: ");

                    try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Hii there!");
                                break;
                            case 2:
                                Console.WriteLine("Good day to you, hope you're doing well!");
                                break;
                            case 3:
                                Console.WriteLine("Goodbye!");
                                running = false;
                                break;
                            default:
                                Console.WriteLine("Please choose a valid option (1-3).");
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That's not a valid number, try again.");
                    }
                }
            }
        }
    }
}
////////////////////////////////////////////////////
///task8
///

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("Sum of even numbers from 1 to " + n + " = " + sum);
        }
    }
}///////////////////////////////////////////////////
