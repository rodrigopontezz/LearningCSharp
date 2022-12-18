namespace ByteBankADM.Employees
{
    public class Designer : InternalEmployee
    {
        //=============================================
        //      Constructors
        //=============================================

        /* When creating an object, both the constructors of the superclass and the subclass are executed, is this
         * exact order. If the superclass has defined a specific constructor with parameters, or even has more than
         * one constructor defined, it's necessary to specificy which one will run. Below there's a demonstration
         * of how to select a specific base constructor to execute.
         */
        public Designer(String cpf, double salary) : base(cpf, salary)
        {

        }


        //=============================================
        //      Public Methods
        //=============================================

        // Example of a virtual method that can be overriden
        public override double GetBonification()
        {
            return Salary * 0.3;
        }

        // Raises salary by 10%
        public override void RaiseSalary()
        {
            Salary *= 1.12;
        }
    }
}
