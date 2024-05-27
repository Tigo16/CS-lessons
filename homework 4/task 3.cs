namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Tigran";
            string surname = "Sargsyan";
            string age = "19";
            string profession = "student";
            Console.WriteLine($"Hello, my name is {name} {surname}, I am {age}y.o. and I am {profession}");
            Console.WriteLine("Hello, my name is {0} {1}, I am {2}y.o. and I am {3}", name, surname, age, profession);
            Console.ReadKey();
        }
    }
}
