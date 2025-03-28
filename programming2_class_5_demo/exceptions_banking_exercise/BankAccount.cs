
namespace exceptions_banking_exercise
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
            if(amount < 0)
            {
                throw new Exception("You can not deposit a negative value.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount > Balance){
                throw new Exception("Money does not just grow in your bank account by itself. You got to earn that much to be able to withdraw that amount.");
            }
            Balance -= amount;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
