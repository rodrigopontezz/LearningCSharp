namespace ByteBankADM.Employees
{
    public abstract class AuthenticableEmployee : InternalEmployee, IAuthenticable
    {

        //=============================================
        //      Properties
        //=============================================

        public string Password { get; set; }


        //=============================================
        //      Constructor
        //=============================================
        protected AuthenticableEmployee(string cpf, double salary) : base(cpf, salary)
        {

        }


        public bool Authenticate(string password)
        {
            return (this.Password == password);
        }
    }
}
