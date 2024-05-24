namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "169";
            int a = int.Parse(str);
            Console.WriteLine(a);

            string str1 = "322 asdf s";
            bool res = int.TryParse(str1, out a);
            Console.WriteLine(res);

            string str2 = "73";
            bool res1 = int.TryParse(str2, out a);
            Console.WriteLine(res1);
        }
    }
}
