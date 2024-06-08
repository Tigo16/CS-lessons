namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[50];
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
                sum += ints[i];
            }
            decimal result = sum / 50;
            Console.WriteLine(result);
        }
    }
}
