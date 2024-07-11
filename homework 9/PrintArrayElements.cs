namespace Print_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = Array.CreateInstance(typeof(int), 10);
            Console.WriteLine("Input 10 elements in the array");
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(int.Parse(Console.ReadLine()), i);
            }
            Console.Write("Elements in the array are: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array.GetValue(i) + " ");
            }
        }
    }
}
