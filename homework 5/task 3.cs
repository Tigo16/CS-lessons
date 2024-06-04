namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 40;
            if (number > 0)
            { 
                if (number < 50)
                {
                    Console.WriteLine("The number is greater than 0 and less than 50");
                }
                else
                {
                    Console.WriteLine("The number is greater than 50");
                }
            }
            else
            {
                Console.WriteLine("The number is less than 0");
            }
            Console.ReadKey();
        }
    }
}
