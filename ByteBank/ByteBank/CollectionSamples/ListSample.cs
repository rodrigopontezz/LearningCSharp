using ByteBank.AccountTypes;

namespace ByteBank.CollectionSamples
{
    public class ListSample
    {

        public List<CheckingAccount> Accounts { get; private set; }


        public ListSample()
        {
            Accounts= new List<CheckingAccount>();
        }


        public void HandleAccount(CheckingAccount account)
        {
            Accounts.Add(account);
            Accounts.Remove(account);

            Accounts.Add(account);
            Accounts.RemoveAt(0);

            Accounts.Add(account);
            Accounts.Clear();

            Accounts.AddRange(new CheckingAccount[] { account });

            var range = Accounts.GetRange(0, 1);

            for (int i = 0; i < range.Count; i++)
            {
                Console.WriteLine(range[i].AccountNumber);
            }

            // Requires IComparable<T> interface implemented in the object.
            Accounts.Sort();

            foreach (CheckingAccount acc in Accounts)
            {
                acc.DisplayAccountInfo();
            }
        }
    }
}
