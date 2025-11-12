namespace wk3gnment.wk3
{
    public class null_operations
    {
        // Declare variables
        string? username = null;
        public void NullCheck()
        {
            // Ternary operator (?:) 
            string message = username != null ? $"Username: {username}" : "Username is null";
            Console.WriteLine(message);
            // Null-coalescing operator (??)
            string message2 = username ?? "DefaultUser";
            Console.WriteLine("Username: " + message2);
            // Null-coalescing assignment operator (??=)
            username ??= "AssignedUser";
            Console.WriteLine("Username after null-coalescing assignment: " + username);
        }
    }
} 