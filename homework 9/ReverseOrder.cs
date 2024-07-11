namespace Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input the number of elements to store in the array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine($"Input {n} elements in the array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The values stored in the array are: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.Write("The values in reverse order are: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
