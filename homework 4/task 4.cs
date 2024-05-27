namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Sunset whispers secrets; the ocean listens, stars dance, moonlight paints dreams, hearts connect.";
            Console.WriteLine("Contains ocean: " + str.Contains("ocean"));
            Console.WriteLine("Contains dance: " + str.Contains("dance"));
            Console.WriteLine("Contains dreams: " + str.Contains("dreams"));
            Console.WriteLine("Contains sunshine: " + str.Contains("sunshine"));
            Console.WriteLine("Contains painting: " + str.Contains("painting"));
            Console.ReadKey();
        }
    }
}
