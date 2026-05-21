namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter first number: ");
            string? firstInput = Console.ReadLine();
            Console.Write("Enter second number: ");
            string? secondInput = Console.ReadLine();

            if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
            {
                int sum = firstNumber + secondNumber;
                int difference = firstNumber > secondNumber ? firstNumber - secondNumber : secondNumber - firstNumber;
                int product = firstNumber * secondNumber;
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Difference: {difference}");
                Console.WriteLine($"Product: {product}");
                
                if (firstNumber == 0 || secondNumber == 0) {
                    Console.WriteLine("Error: Division by zero is not allowed!");
                } else {
                    int quotient = firstNumber > secondNumber ? firstNumber / secondNumber : secondNumber / firstNumber;
                    Console.WriteLine($"quotient: {quotient}");
                }
                               
            }
            else {

                Console.WriteLine("Error: One or both inputs are not valid numbers!");
            }


        }
    }
}
