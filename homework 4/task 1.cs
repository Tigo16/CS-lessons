namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            Console.WriteLine("String Lenght: " + str.Length);
            Console.WriteLine("String Uppercase: " + str.ToUpper());
            Console.WriteLine("String Lowercase:" + str.ToLower());
            Console.WriteLine("Substring: " + str.Substring(7));
	    Console.ReadKey();
        }
    }
}
