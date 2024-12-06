
namespace exceptions_banking_exercise
{
    public class InsufficientFundsException : ApplicationException
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
}
