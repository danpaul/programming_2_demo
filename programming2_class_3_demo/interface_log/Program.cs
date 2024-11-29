namespace interface_log
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
            // part 1 - classes implementing interface

            // creating two very differnt objects that both implement ILoggable
            User joe = new User(
                123, // required by ILoggable
                new DateTime(2020, 1, 1), // required by ILoggable
                "Joe",
                "Joeson"
            );
            Order order = new Order(
                456, // required by ILoggable
                DateTime.Now, // required by ILoggable
                99.99M
            );

            // part 2 - Logger
            Logger logger = new Logger();

            // add items to our logger
            // even though the structure of these objects is different, the logger.Add() method
            //  accepts anything that implements ILoggable
            logger.Add(joe);
            logger.Add(order);

            // display our logged items
            logger.DisplayAll();
        }
    }
}
