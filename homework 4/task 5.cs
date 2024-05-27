namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "apple, banana, orange";
            string str2 = "C#, Java, JavaScript, Pyton";

            string[] mini_str1 = str1.Split(',');
            string[] mini_str2 = str2.Split(',');

            Console.WriteLine(mini_str1[0].Trim());
            Console.WriteLine(mini_str1[1].Trim());
            Console.WriteLine(mini_str1[2].Trim());

            Console.WriteLine(mini_str2[0].Trim());
            Console.WriteLine(mini_str2[1].Trim());
            Console.WriteLine(mini_str2[2].Trim());
            Console.WriteLine(mini_str2[3].Trim());
            Console.ReadKey();
        }
    }
}
