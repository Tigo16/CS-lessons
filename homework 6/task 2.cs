namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n;
            int sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
