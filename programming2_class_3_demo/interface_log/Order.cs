
namespace interface_log
{
    internal class Order : ILoggable
    {
        public int ID { get; } // required by ILoggable
        public DateTime Created { get; } // required by ILoggable
        public decimal Total { get; }

        public Order(
            int id,
            DateTime created,
            decimal total)
        {
            ID = id;
            Created = created;
            Total = total;
        }

        public string GetLogMessage() // required by ILoggable
        {
            return $"Order total: {Total:0:00}";
        }
    }
}
