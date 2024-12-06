
namespace exceptions_banking_exercise_solution
{
    public class InsufficientFundsException : ApplicationException
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
}
