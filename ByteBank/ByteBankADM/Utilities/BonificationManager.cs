using ByteBankADM.Employees;

namespace ByteBankADM.Utilities
{
    public class BonificationManager
    {

        //=============================================
        //      Properties
        //=============================================
        public double TotalBonification { get; private set; }


        //=============================================
        //      Public Methods
        //=============================================

        public void SumBonification(InternalEmployee employee)
        {
            TotalBonification += employee.GetBonification();
        }
    }
}
