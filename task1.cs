namespace spark_to_code_part_2
{
    internal class task1
    {
       
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
