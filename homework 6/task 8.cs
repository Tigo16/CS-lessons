namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a;
            a = Convert.ToUInt32(Console.ReadLine());
            uint b;
            b = Convert.ToUInt32(Console.ReadLine());
            for (uint i = a; i <= b; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
