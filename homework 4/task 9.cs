namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "HeLlo";
          
            bool res1 = string.Equals(str1, str2, StringComparison.CurrentCulture);
            bool res2 = string.Equals(str1, str2, StringComparison.CurrentCultureIgnoreCase);
            bool res3 = string.Equals(str1, str2, StringComparison.InvariantCulture);
            bool res4 = string.Equals(str1, str2, StringComparison.InvariantCultureIgnoreCase);
            bool res5 = string .Equals(str1, str2, StringComparison.Ordinal);
            bool res6 = string .Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
          
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine(res6);
        }
    }
}
