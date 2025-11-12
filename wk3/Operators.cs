namespace wk3gnment.wk3
{
    public class Operators
    {
        // Declare variables
        int a;
        int b;
        int sum;

        // Method to get user input
        public void GetInput()
        {
            Console.Write("Enter first number: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Invalid input. Enter first number: ");
            }
            Console.Write("Enter second number: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Invalid input. Enter second number: ");
            }
        }

        // Method to perform addition
        public void Add()
        {
            // Perform addition
            sum = a + b;
            Console.WriteLine("Addition: " + sum);
        }

        public void Subtract()
        {
            // Perform subtraction
            sum = a - b;
            Console.WriteLine("Subtraction: " + sum);
        }
        public void Multiply()
        {
            // Perform multiplication
            sum = a * b;
            Console.WriteLine("Multiplication: " + sum);
        }
        public void Divide()
        {
            // Perform division
            if (b != 0)
            {
                sum = a / b;
                Console.WriteLine("Division: " + sum);
            }
            else
            {
                Console.WriteLine("Error: Division by zero");
            }
        }
        // Odd Even Finder
        public void OddEvenFinder()
        {
            Console.Write("Enter a number to check if it's odd or even: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Enter a number: ");
            }
            Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
        }
    }
}