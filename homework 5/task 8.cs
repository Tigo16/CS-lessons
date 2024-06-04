namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = 28;
            bool isRaining = false;
            if (temperature > 20 && !isRaining) {
                Console.WriteLine("Good weather for a walk");
            }
            else
            {
                Console.WriteLine("Stay indoors");
            }
            Console.ReadKey();
        }
    }
}
