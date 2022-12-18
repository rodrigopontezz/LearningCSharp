using System.Runtime.Serialization;

namespace ByteBank.Exceptions
{
    public class FinancialOperationException : Exception
    {

        public FinancialOperationException()
        {

        }

        public FinancialOperationException(string message) : base(message)
        {

        }

        public FinancialOperationException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected FinancialOperationException(SerializationInfo info, StreamingContext context) : base(info, context) 
        { 
        
        }
    }
}
