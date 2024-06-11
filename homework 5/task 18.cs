namespace task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 3;
            switch (option)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Option {0} selected", option);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
