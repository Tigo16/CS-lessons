namespace Print_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Input 10 elements in the array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in the array are: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
