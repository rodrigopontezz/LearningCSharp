using ByteBank.Customer;
using ByteBank.Exceptions;

namespace ByteBank.AccountTypes
{
    public class CheckingAccount : IComparable<CheckingAccount>
    {
        // Private field name conventions
        private int _agencyNumber;
        private double _balance;

        // Auto-implemented properties examples (nested)
        private Holder _userHolder;

        // Auto-implemented static property with private set
        public static long TotalAccountsCreated { get; private set; }

        // Explicit property declaration example
        private string _accountNumber;
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { if (value is not null)  _accountNumber = value; }
        }
        

        public CheckingAccount(int agencyNumber, string accountNumber, double balance, string holderName, string cpf, string job)
        {
            _agencyNumber = agencyNumber;
            _accountNumber = accountNumber;
            _userHolder = new()
            {
                Name = holderName,
                Cpf = cpf,
                Job = job
            };
            SetBalance(balance);
            TotalAccountsCreated++;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {_userHolder.Name}.");
            Console.WriteLine($"Cpf: {_userHolder.Cpf}");
            Console.WriteLine($"Job: {_userHolder.Job}");
            Console.WriteLine($"Agency Number: {_agencyNumber}.");
            Console.WriteLine($"Account Number: {_accountNumber}.");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"{_accountNumber} account balance is U$ {string.Format("{0:0.00}", _balance)}.\n");
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;

                Console.WriteLine($"The operation was successful.\n{_accountNumber} new account balance is U$ {string.Format("{0:0.00}", _balance)}.\n");
            }
            else
            {
                throw new InvalidTransactionException("The amount must be superior to U$ 0 for the deposit operation.\n");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;

                Console.WriteLine($"The operation was successful.\n{_accountNumber} new account balance is U$ {string.Format("{0:0.00}", _balance)}.\n");
            }
            else if (_balance < amount)
            {
                throw new InvalidTransactionException("The operation was unsuccessful. You have unsufficient funds available.\n");
            }
            else
            {
                throw new InvalidTransactionException("The amount must be superior to U$ 0 for the withdraw operation.\n");
            }
        }

        public void Transfer(double amount, CheckingAccount receiver)
        {
            try
            {
                Withdraw(amount);
                receiver.Deposit(amount);
            }
            catch (InvalidTransactionException ex)
            {
                throw new FinancialOperationException("The operation was unsuccessful.\n", ex);
            }
            finally
            {
                Console.WriteLine("This is always executed.");
            }
        }


        private void SetBalance(double amount)
        {
            if (amount < 0)  return;
            
            _balance = amount;
        }

        /// <summary>
        /// Necessary to enable the Sort() method in the List<T> interface.
        /// </summary>
        /// <param name="other">The CheckingAccount that will be compared to.</param>
        /// <returns>
        /// Returns 1 if "other" occurs after this instance in the classification order.
        /// Returns 0 if "other" occurs in the same position of this instance in the classfication order.
        /// Returns -1 if "other" occurs before this instance in the classification order.
        /// </returns>
        public int CompareTo(CheckingAccount? other)
        {
            int result = 1;

            if (other != null)
            {
                result = _agencyNumber.CompareTo(other._agencyNumber);
            } 
                
            return result;
        }
    }
}
