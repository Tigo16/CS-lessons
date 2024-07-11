namespace Sum_of_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            int sum = 0;
            Console.WriteLine("Input 3 elements in the array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
        }
    }
}
