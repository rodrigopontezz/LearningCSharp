namespace ByteBankADM.Employees
{
    public abstract class InternalEmployee
    {

        //=============================================
        //      Properties
        //=============================================

        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; protected set; }


        //=============================================
        //      Constructors
        //=============================================

        // Here to demonstrate how to select a specific constructor to run from subclass.
        public InternalEmployee(string cpf, double salary)
        {
            Cpf = cpf;
            Salary = salary;
        }


        //=============================================
        //      Public Methods
        //=============================================
        
        // Example of a virtual method that can be overriden
        public virtual double GetBonification()
        {
            return Salary * 0.1;
        }

        // Example of an abstract method
        public abstract void RaiseSalary();
    }
}
