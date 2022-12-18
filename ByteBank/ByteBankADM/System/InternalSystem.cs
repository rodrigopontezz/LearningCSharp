using ByteBankADM.Employees;

namespace ByteBankADM.System
{
    public class InternalSystem
    {
        public static bool DoLogin(AuthenticableEmployee authenticable, string password)
        {
            if (password is null)
            {
                throw new ArgumentException("No password was entered. Please try again.", nameof(password));
            }
            
            bool isAuthenticated = authenticable.Authenticate(password);

            if (isAuthenticated)
            {
                Console.WriteLine($"{authenticable.Name} has authenticated successfully!");
            }
            else
            {
                Console.WriteLine($"The password {authenticable.Name} has entered is incorrect. Please try again.");
            }

            return isAuthenticated;
        }
    }
}
