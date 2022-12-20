using ByteBank.AccountTypes;

namespace ByteBank.CollectionSamples
{
    public class CheckingAccountList
    {
        private int _currentIndex;

        public CheckingAccount[] Accounts { get; private set; }

        // Indexer
        public CheckingAccount this[int index]
        {
            get
            {
                return GetAccount(index);
            }
        }


        public CheckingAccountList()
        {
            Accounts = new CheckingAccount[0];
        }


        public void AddAccount(CheckingAccount account)
        {
            ResizeArray();
            Accounts[_currentIndex] = account;
            _currentIndex++;

            Console.WriteLine($"Account {account.AccountNumber} has been added.");
        }


        public void RemoveAccount(CheckingAccount account)
        {
            int indexToRemove = -1;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] == account)
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove >= 0)
            {
                _currentIndex--;
                CheckingAccount[] newAccountList = new CheckingAccount[_currentIndex];

                int j = 0;
                for (int i = 0; i < _currentIndex; i++)
                {
                    if (j == indexToRemove) j++;

                    newAccountList[i] = Accounts[j++];
                }

                Accounts = newAccountList;
            }

            Console.WriteLine("The account has been removed.");
        }


        public CheckingAccount GetAccount(int index)
        {
            if (index < 0 || index > _currentIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return Accounts[index];
        }


        public void ResizeArray()
        {
            CheckingAccount[] newArray = new CheckingAccount[_currentIndex + 1];

            for (int i = 0; i < Accounts.Length; i++)
            {
                newArray[i] = Accounts[i];
            }

            Accounts = newArray;

            Console.WriteLine($"The array has been resized to {_currentIndex + 1}.");
        }


        public void ListAccounts()
        {
            Console.WriteLine("\nList of accounts:");

            foreach (CheckingAccount account in Accounts)
            {
                Console.WriteLine(account.AccountNumber);
            }

            Console.WriteLine();
        }


        public CheckingAccount FindAccountByAccountNumber(string accountNumber)
        {
            return Accounts.Where(acc => acc.AccountNumber == accountNumber).FirstOrDefault();
        }


        public CheckingAccount FindAccountByAgencyNumber(int agencyNumber)
        {
            return Accounts.Where(acc => acc.AgencyNumber == agencyNumber).FirstOrDefault();
        }

    }
}
