namespace wk3gnment.wk3
{
    public class ElseSwitch
    {
        public void ageCheck()
        {
            Console.WriteLine("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Invalid input. Enter your age: ");
            }

            // Using if-else to check age group
            if (age < 13)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age >= 13 && age < 20)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age >= 20 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }

        public void dayOfWeekSwitch()
        {
            Console.WriteLine("Enter a number (1-7) to get the corresponding day of the week: ");
            int day;
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
            {
                Console.Write("Invalid input. Enter a number (1-7): ");
            }

            // Using switch-case to determine the day of the week
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}