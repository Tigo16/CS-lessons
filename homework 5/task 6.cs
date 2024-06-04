namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "pause";
            switch (command) 
            {
                case "start":
                    Console.WriteLine("start");
                    break;
                case "stop":
                    Console.WriteLine("stop");
                    break;
                case "pause":
                    Console.WriteLine("pause");
                    break;
                case "resume":
                    Console.WriteLine("resume");
                    break;
            }
            Console.ReadKey();
        }
    }
}
