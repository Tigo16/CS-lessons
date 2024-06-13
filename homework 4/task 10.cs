namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";

            int code1 = str1.GetHashCode();
            int code2 = str2.GetHashCode();
            int code3 = str3.GetHashCode();
            bool codeEquals = code1 == code2;

            Console.WriteLine(code1);
            Console.WriteLine(code2);
            Console.WriteLine(code3);
            Console.WriteLine(codeEquals);
        }
    }
}
