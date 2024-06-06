namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 14;
            int sum = 0;
            for (int i = 0; i <= n; i++) {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
