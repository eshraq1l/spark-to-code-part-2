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