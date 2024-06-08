namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[10];
            int max = int.MinValue;
            for (int i = 0; i < ints.Length; i++) {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > max)
                {
                    max = ints[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
