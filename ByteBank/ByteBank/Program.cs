using ByteBank.AccountTypes;
using ByteBank.Help;
using ByteBank.Screens;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ByteBank main app
            CheckingAccount account = new(1033, "1234-X", 312.30, "Andrew Hawkins", "32445211135", "Developer");
            CheckingAccount accountReceiver = new(2598, "2020-5", 4050.95, "Mary Antoniette", "876533562211", "Musician");

            #region
            //StartScreen screen = new (account, accountReceiver);
            //screen.DisplayOptions();
            #endregion

            #region
            // Properties usage sample
            //CheckingAccount accountAnotherClient = new(4455, "9472-3", 20000000000.00, "Thiago Lacerda", "557788331122", "Actor");
            //accountAnotherClient.AccountNumber = "3441-2";
            #endregion

            #region
            //WordFinderScreen screen = new();
            //screen.DisplayOptions();
            #endregion

            #region
            // Resizeable array
            CheckingAccountList accountManager = new();
            accountManager.AddAccount(account);
            accountManager.AddAccount(accountReceiver);
            accountManager.ListAccounts();
            accountManager.RemoveAccount(account);
            accountManager.ListAccounts();

            // Indexer
            Console.WriteLine($"This is accessed through an indexer: {accountManager[0].AccountNumber}");

            #endregion
        }
    }
}