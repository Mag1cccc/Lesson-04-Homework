namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                if (number % 5 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
    }
}
