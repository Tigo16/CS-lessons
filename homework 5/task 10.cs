namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 25;
            int c = 12;
            if (a > b && a > c) {
                Console.WriteLine("The largest number is a");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The largest number is b");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("The largest number is a");
            }
            Console.ReadKey();
        }
    }
}
