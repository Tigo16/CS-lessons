namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "apple, banana, orange";
            string str2 = "C#, Java, JavaScript, Pyton";

            string[] fruts = str1.Split(',');
            string[] langs = str2.Split(',');

            Console.WriteLine(fruts[0].Trim());
            Console.WriteLine(fruts[1].Trim());
            Console.WriteLine(fruts[2].Trim());

            Console.WriteLine(langs[0].Trim());
            Console.WriteLine(langs[1].Trim());
            Console.WriteLine(langs[2].Trim());
            Console.WriteLine(langs[3].Trim());
            Console.ReadKey();
        }
    }
}
