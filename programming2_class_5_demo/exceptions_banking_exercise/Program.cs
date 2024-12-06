namespace exceptions_banking_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= numbers.Length; i++)
            {


            }


            BankAccount account = new BankAccount(1000);

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
    }
}
