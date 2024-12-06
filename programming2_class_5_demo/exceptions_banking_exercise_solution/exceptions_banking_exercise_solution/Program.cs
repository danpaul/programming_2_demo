namespace exceptions_banking_exercise_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {

            BankAccount account = new BankAccount(1000);

            try
            {
                Console.WriteLine($"Current Balance: {account.GetBalance()}");

                Console.Write("Enter amount to deposit: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());
                account.Deposit(depositAmount);
                Console.WriteLine($"New Balance after deposit: {account.GetBalance()}");

                Console.Write("Enter amount to withdraw: ");
                decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                account.Withdraw(withdrawAmount);
                Console.WriteLine($"New Balance after withdrawal: {account.GetBalance()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Input Error: {ex.Message}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Transaction Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Transaction complete.");
            }
        }
    }
}
