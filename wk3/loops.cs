namespace wk3gnment.wk3
{
    public class loops
    {
        public void calculateSum()
        {
            Console.Write("Enter a positive integer: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }
            // Using for loop prining the sum from 1 to N.
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");
        }

        public void printNumbers()
        {
            Console.Write("Enter a positive integer: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }

            int i = 1;
            Console.WriteLine("Printing numbers from 1 to 20, skipping multiples of 4 and stopping at 15:");
            while (i <= 20)
            {
                if (i == 15)
                {
                    break;
                }
                if (i % 4 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }

        public void sumofArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("The sum of the array elements is: " + sum);
        }
    }
}