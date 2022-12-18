namespace ByteBankADM.Employees
{
    public interface IAuthenticable
    {
        public string Password { get; }

        public bool Authenticate(string password);
    }
}
