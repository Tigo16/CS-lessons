namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "HELLO";

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.CompareTo(str2));
        }
    }
}
