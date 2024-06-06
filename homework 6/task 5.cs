namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num = 0;
            str = Console.ReadLine();
            for (int i = 0; i <= str.Length - 1; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        num++;
                        break;
                    case 'e':
                        num++;
                        break;
                    case 'i':
                        num++;
                        break;
                    case 'o':
                        num++;
                        break;
                    case 'u':
                        num++;
                        break;
                }
            }
            Console.WriteLine(num);
        }
    }
}
