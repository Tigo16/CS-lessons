namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int fib;
            int n1 = 0;
            int n2 = 1;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(n1 + " ");
                fib = n1;
                n1 = n2;
                n2 = fib + n1;
            }
        }
    }
}
