namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuOption = 2;
            if (menuOption >= 1 && menuOption <= 3) {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Start Game");
                        break;
                    case 2:
                        Console.WriteLine("Load Game");
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
