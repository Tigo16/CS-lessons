namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i + 1));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    if (i == j)
                    {
                        continue;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
