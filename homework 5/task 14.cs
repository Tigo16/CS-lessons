namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint age;
            age = Convert.ToUInt32(Console.ReadLine());
            if (age >= 0 && age <= 1)
            {
                Console.WriteLine("Infant");
            }
            else if (age >= 2 && age <= 4)
            {
                Console.WriteLine("Toddler");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teen");
            }
            else if (age >= 20 && age <= 39)
            {
                Console.WriteLine("Teen");
            }
            else if (age >= 40 && age <= 59)
            {
                Console.WriteLine("Middle Age Adult");
            }
            else
            {
                Console.WriteLine("Senior Adult");
            }
        }
    }
}
