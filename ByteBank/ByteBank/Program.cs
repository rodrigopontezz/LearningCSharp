using ByteBank.AccountTypes;
using ByteBank.CollectionSamples;
using ByteBank.Help;
using ByteBank.Screens;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new(1033, "1234-X", 312.30, "Andrew Hawkins", "32445211135", "Developer");
            CheckingAccount accountReceiver = new(2598, "2020-5", 4050.95, "Mary Antoniette", "876533562211", "Musician");

            #region ByteBank Main App 
            //StartScreen screen = new (account, accountReceiver);
            //screen.DisplayOptions();
            #endregion
            #region Properties usage sample
            //CheckingAccount accountAnotherClient = new(4455, "9472-3", 20000000000.00, "Thiago Lacerda", "557788331122", "Actor");
            //accountAnotherClient.AccountNumber = "3441-2";
            #endregion
            #region Word Finder - Arrays
            //WordFinderScreen screen = new();
            //screen.DisplayOptions();
            #endregion
            #region Resizeable array with Indexer
            //CheckingAccountList accountManager = new();
            //accountManager.AddAccount(account);
            //accountManager.AddAccount(accountReceiver);
            //accountManager.ListAccounts();
            //accountManager.RemoveAccount(account);
            //accountManager.ListAccounts();

            //// Indexer
            //Console.WriteLine($"This is accessed through an indexer: {accountManager[0].AccountNumber}");
            #endregion
            #region Class Generics example
            //string nancy = "Nancy Wheeler";
            //GenericsPrinter<string>.PrintValue(nancy);

            //int age = 29;
            //GenericsPrinter<int>.PrintValue(age);

            //GenericsPrinter<CheckingAccount>.PrintValue(account);
            #endregion
            #region Sorting Lists with IComparable implemented
            //ListSample listSample = new ListSample();
            //listSample.HandleAccount(account);
            #endregion
            #region Explicit LINQ expression
            CheckingAccountList accountManager = new();
            accountManager.AddAccount(account);
            accountManager.AddAccount(accountReceiver);

            LINQCheckingAccount linqSample = new LINQCheckingAccount();
            foreach (CheckingAccount acc in linqSample.FindAccountsByAgencyNumber(accountManager,1033))
            {
                acc.DisplayAccountInfo();
            }
            #endregion
        }
    }
}