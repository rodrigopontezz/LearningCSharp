using ByteBank.AccountTypes;
using ByteBank.Exceptions;

namespace ByteBank.Screens
{
    public class StartScreen
    {
        private readonly CheckingAccount _account;
        private readonly CheckingAccount _accountReceiver;

        public StartScreen(CheckingAccount account, CheckingAccount accountReceiver)
        {
            _account = account;
            _accountReceiver = accountReceiver;
        }

        public void DisplayOptions()
        {
            PrintAvailableOperations();
            SelectOperation();
        }

        private static void PrintAvailableOperations()
        {
            Console.Write("Welcome to the ByteBank!");
            Console.WriteLine($" - Accounts created: {CheckingAccount.TotalAccountsCreated}\n");
            Console.WriteLine("1 - Deposit");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Balance");
            Console.WriteLine("5 - Account Info");
            Console.WriteLine("0 - Exit\n");
        }

        private void SelectOperation()
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();

                try
                {
                    Console.Clear();
                    PrintAvailableOperations();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Clear();
                            Console.Write("Please tell the amount you want to deposit: U$ ");
                            _account.Deposit(ReadAmount());
                            break;
                        case ConsoleKey.D2:
                            Console.Clear();
                            Console.Write("Please tell the amount you want to withdraw: U$ ");
                            _account.Withdraw(ReadAmount());
                            break;
                        case ConsoleKey.D3:
                            Console.Clear();
                            Console.Write("Please tell the amount you want to transfer: U$ ");
                            _account.Transfer(ReadAmount(), _accountReceiver);
                            break;
                        case ConsoleKey.D4:
                            _account.DisplayBalance();
                            break;
                        case ConsoleKey.D5:
                            _account.DisplayAccountInfo();
                            break;
                        case ConsoleKey.D0:
                            Console.WriteLine("Thanks for coming! ByteBank wishes you happy holidays!\n");
                            break;
                        default:
                            break;
                    }
                }
                catch (FinancialOperationException ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"UNKNOWN ERROR: {ex.Message}");
                }
            }
            while (keyInfo.Key != ConsoleKey.D0);
        }


        private static double ReadAmount()
        {
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("There was an unexpected error in the application. Please try again.");
            }

            return amount;
        }
    }
}
