namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            bool isPalindrome = true;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] != str[str.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("It isn't palindrome");
            }
        }
    }
}
