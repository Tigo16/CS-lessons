namespace task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 32;
            int c = 17;
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("The triangle is equilateral");
                }
                if (a == b || b == c || a == c)
                {
                    Console.WriteLine("The triangle is isosceles");
                }
                if (a != b && b != c && a != c)
                {
                    Console.WriteLine("The triangle is scalene");
                }
            }
            else
            {
                Console.WriteLine("It's not a triangle");
            }
        }
    }
}
