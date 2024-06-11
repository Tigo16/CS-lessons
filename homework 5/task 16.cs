namespace task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 33;
            int c = 24;
            int d = 16;
            if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
            if (b < a)
            {
                if (b < c)
                {
                    if (b < d)
                    {
                        Console.WriteLine(b);
                    }
                }
            }
            if (c < a)
            {
                if (c < b)
                {
                    if (c < d)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            if (d < a)
            {
                if (d < b)
                {
                    if (d < c)
                    {
                        Console.WriteLine(d);
                    }
                }
            }
        }
    }
}
