namespace exception_type
{
    // define a custom exception
    // it's possible to extend `Exception` but `ApplicationException` is preffered
    //  for custom exceptions
    public class DatabaseConnectionException : ApplicationException
    {
        public DatabaseConnectionException(string message) : base(message) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            try
            {
                connectToDatabase();
            }
            // catch the custom exception
            catch (DatabaseConnectionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // catch general exceptions
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void connectToDatabase()
        {
            // uh oh, database is down!
            throw new DatabaseConnectionException("the database is offline");
        }
    }


}
