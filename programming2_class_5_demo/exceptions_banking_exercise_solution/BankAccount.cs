
namespace exceptions_banking_exercise_solution
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InsufficientFundsException("Insufficient funds for this withdrawal.");
            }
            Balance -= amount;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
