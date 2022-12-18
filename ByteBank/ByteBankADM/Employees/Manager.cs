namespace ByteBankADM.Employees
{
    public class Manager : AuthenticableEmployee
    {

        //=============================================
        //      Section
        //=============================================

        /* When creating an object, both the constructors of the superclass and the subclass are executed, is this
         * exact order. If the superclass has defined a specific constructor with parameters, or even has more than
         * one constructor defined, it's necessary to specificy which one will run. Below there's a demonstration
         * of how to select a specific base constructor to execute.
         */
        public Manager(string cpf, double salary) : base(cpf,salary)
        {

        }

        //=============================================
        //      Public Methods 
        //=============================================

        // Method that overrides a virtual method extended from the superclass
        public override double GetBonification()
        {
            return Salary * 0.8;
        }

        // Overrides method in a property with a "protected set"
        public override void RaiseSalary()
        {
            Salary *= 1.15;
        }

        // Method that uses "base" to access the superclass' virtual method
        public double GetSemestralPrize()
        {
            return GetBonification() + base.GetBonification();
        }
    }
}
