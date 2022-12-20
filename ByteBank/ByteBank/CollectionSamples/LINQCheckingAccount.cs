using ByteBank.AccountTypes;

namespace ByteBank.CollectionSamples
{
    public class LINQCheckingAccount
    {
        
        public List<CheckingAccount> FindAccountsByAgencyNumber(CheckingAccountList accountManager, int agencyNumber)
        {
            var query = (
                from account in accountManager.Accounts
                where account.AgencyNumber == agencyNumber
                select account
            ).ToList();

            return query;
        }
    }
}
