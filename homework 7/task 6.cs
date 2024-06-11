namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            double res = num;
            double sum = 0;
            int pow = num.ToString().Length;
            while (num > 0)
            {
                sum += Math.Pow(num % 10, pow);
                num /= 10;
            }
            if (res == sum)
            {
                Console.WriteLine("It is an Armstrong number");
            }
            else
            {
                Console.WriteLine("It isn't an Armstrong number");
            }
        }
    }
}
