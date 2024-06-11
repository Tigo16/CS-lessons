namespace task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 147;
            int b = 193;
            int c = 74;
            int d = 160;
            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine(b);
                    }
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    if (c > d)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            if (d > a)
            {
                if (d > b)
                {
                    if (d > c)
                    {
                        Console.WriteLine(d);
                    }
                }
            }
        }
    }
}
