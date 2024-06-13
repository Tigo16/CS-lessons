namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "TTT";
            string str2 = "TTT";
            string str3 = new string('T', 3);

            bool refEquals1 = ReferenceEquals(str1, str2);
            bool refEquals2 = ReferenceEquals(str1, str3);

            Console.WriteLine(refEquals1);
            Console.WriteLine(refEquals2);
        }
    }
}
