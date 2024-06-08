namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            char symbol;
            int count = 0;
            symbol = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
