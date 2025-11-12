namespace wk3gnment.wk3
{
    public class TryCatch
    {
        public void NumCheck()
        {
            int number;
            Console.Write("Enter a number: ");
            string? input = Console.ReadLine();

            try
            {
                number = Convert.ToInt32(input);
                Console.WriteLine("Entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Number is too large or too small.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error: No input provided.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }

        public void AskPasswords()
        {
            Console.Write("Enter a password: ");
            string? password = Console.ReadLine();
            try
            {
                if (password == null || password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters long.");
                }
                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Password checked.");
            }
        }
    }
}