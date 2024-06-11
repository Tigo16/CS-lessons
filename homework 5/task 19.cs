namespace task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            symbol = Convert.ToChar(Console.ReadLine());
            switch (symbol)
            {
                case 'a': 
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Symbol is a vowel");
                    break;
                default:
                    Console.WriteLine("Symbol is a consonant");
                    break;
            }
        }
    }
}
