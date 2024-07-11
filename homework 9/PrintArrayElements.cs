namespace Print_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array");
            int n = int.Parse(Console.ReadLine());

            Array array = Array.CreateInstance(typeof(int), n);

            Console.WriteLine($"Input {n} elements in the array");
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(int.Parse(Console.ReadLine()), i);
            }

            Console.Write("Elements in the array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array.GetValue(i) + " ");
            }
        }
    }
}
