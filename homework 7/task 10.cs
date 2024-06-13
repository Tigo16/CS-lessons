namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rand = new Random().Next(1, 100);
            int num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > rand)
                {
                    Console.WriteLine("Your number is greater");
                }
                if (num < rand)
                {
                    Console.WriteLine("Your number is less");
                }
            } while (num != rand);

            Console.WriteLine("You guessed the number");
        }
    }
}
