namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start;
            start = Convert.ToInt32(Console.ReadLine());
            int end;
            end = Convert.ToInt32(Console.ReadLine());
            for(int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }    
        }
    }
}
