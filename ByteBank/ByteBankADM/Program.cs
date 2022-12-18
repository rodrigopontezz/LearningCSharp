using ByteBankADM.Employees;
using ByteBankADM.System;
using ByteBankADM.Utilities;

namespace ByteBankADM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Designer designer = new("123456789", 3445.23)
            {
                Name = "Andrew Hawkins"
            };

            Manager manager = new("987654321", 15000.90)
            {
                Name = "Rita Von Hunty",
                Password = "555"
            };

            #region
            //BonificationManager bonificationManager = new();

            //console.writeline($"name: {designer.name}");
            //console.writeline($"wage: u$ {string.format("{0:0.00}", designer.salary)}");
            //console.writeline($"bonification: u$ {string.format("{0:0.00}", designer.getbonification())}");

            //bonificationmanager.sumbonification(designer);
            //bonificationmanager.sumbonification(manager);

            //console.writeline($"semestral prize: u$ {string.format("{0:0.00}", manager.getsemestralprize())}");
            //console.writeline($"total bonification: u$ {string.format("{0:0.00}", bonificationmanager.totalbonification)}");

            //manager.raisesalary();

            //console.writeline($"new manager salary: u$ {string.format("{0:0.00}", manager.salary)}");
            #endregion

            //InternalSystem.DoLogin(designer, "123");
            try
            {
                InternalSystem.DoLogin(manager, "999");
                InternalSystem.DoLogin(manager, null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Problem with the parameter: {ex.ParamName}");
                Console.WriteLine($"The problem was: {ex.Message}");
            }
        }
    }
}