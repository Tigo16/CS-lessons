namespace Sum_of_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = Array.CreateInstance(typeof(int), 3);
            int sum = 0;
            
            Console.WriteLine("Input 3 elements in the array");
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(int.Parse(Console.ReadLine()), i);
                sum += (int)array.GetValue(i);
            }
            
            Console.Write($"Sum of all elements stored in the array is: {sum}");
        }
    }
}
