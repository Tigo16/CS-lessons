namespace Copy_Elements_to_Another_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array1 = Array.CreateInstance(typeof(int), 3);
            Array array2 = Array.CreateInstance(typeof(int), 3);
            Console.WriteLine("Input 3 elements in the array");
            for (int i = 0; i < array1.Length; i++)
            {
                array1.SetValue(int.Parse(Console.ReadLine()), i);
            }
            Array.Copy(array1, array2, array1.Length);

            Console.Write("Elements stored in the first array: ");
            foreach (int i in array1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Elements copied into the second array: ");
            foreach (int i in array2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
