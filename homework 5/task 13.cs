namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 63;
            if (grade <= 100 && grade >= 90) {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("Average");
            }
            else if (grade >= 20)
            {
                Console.WriteLine("Poor");
            }
            else 
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }
    }
}
