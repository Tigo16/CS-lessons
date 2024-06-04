namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            bool hasLicense = false;
            if (age >= 18 && hasLicense) {
                Console.WriteLine("Can drive");
            }
            else
            {
                Console.WriteLine("Can't drive");
            }
            Console.ReadKey();
        }
    }
}
