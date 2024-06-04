namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 77;
            if (score >= 90)
            {
                Console.WriteLine("It's A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("It's B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("It's C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("It's D")
            }
            else
            {
                Console.WriteLine("It's F")
            }
            Console.ReadKey();
        }
    }
}
