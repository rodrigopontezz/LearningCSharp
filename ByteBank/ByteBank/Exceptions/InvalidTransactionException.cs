namespace ByteBank.Exceptions
{
    public class InvalidTransactionException : FinancialOperationException
    {
        
        public InvalidTransactionException(string message) : base(message)
        {

        }

    }
}
