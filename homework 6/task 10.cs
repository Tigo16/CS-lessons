namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0) {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
