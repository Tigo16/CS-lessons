namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n;
            int res = 1;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            Console.WriteLine(res);
        }
    }
}
