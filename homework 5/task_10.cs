namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 25;
            int c = 12;
            if(a > b) {
                if(a > c)
                {
                    Console.WriteLine("The largest number is a");
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("The largest number is b");
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("The largest number is c");
                }
            }
            Console.ReadKey();
        }
    }
}
