namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // RunTaskOne();
            RunTaskTwo();
        }
        //Task 1
        static void RunTaskOne() {
            Console.Write("Enter a number: ");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out var number))
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

        // Task 2
        static void RunTaskTwo() {
            Console.Write("Enter first number: ");
            var firstInput = Console.ReadLine();
            Console.Write("Enter second number: ");
            var secondInput = Console.ReadLine();

            if (int.TryParse(firstInput, out var firstNumber) && int.TryParse(secondInput, out var secondNumber))
            {
                var sum = firstNumber + secondNumber;
                var difference = firstNumber > secondNumber ? firstNumber - secondNumber : secondNumber - firstNumber;
                var product = firstNumber * secondNumber;
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Difference: {difference}");
                Console.WriteLine($"Product: {product}");

                if (firstNumber == 0 || secondNumber == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed!");
                }
                else
                {
                    var quotient = firstNumber > secondNumber ? firstNumber / secondNumber : secondNumber / firstNumber;
                    Console.WriteLine($"quotient: {quotient}");
                }

            }
            else
            {

                Console.WriteLine("Error: One or both inputs are not valid numbers!");
            }
        }
    }

}
