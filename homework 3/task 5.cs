namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte and int to double
            int a1 = 729;
            double d1 = (double)a1;
            byte b1 = 120;
            double d2 = (double)b1;

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            // double and decimel to int and byte
            double d3 = 132.1444;
            int a2 = (int)d3;
            byte b2 = (byte)d3;

            Console.WriteLine(a2);
            Console.WriteLine(b2);

            decimal d4 = 167.123231m;
            int a3 = (int)d4;
            byte b3 = (byte)d4;

            Console.WriteLine(a3);
            Console.WriteLine(b3);

            // double and int to char
            int a4 = 250;
            double d5 = 114.1278;
            char c1 = (char)a4;
            char c2 = (char)d5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
