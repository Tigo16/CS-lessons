namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -58;
            if (num > 0) {
                Console.WriteLine("The number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
            Console.ReadKey();
        }
    }
}
