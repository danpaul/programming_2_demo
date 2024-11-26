using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_log
{
    internal class User : ILoggable
    {
        public int ID { get; } // required by ILoggable
        public DateTime Created { get; } // required by ILoggable
        public string FirstName { get; private set; }
        public string LastName { get; }

        public User(int id, DateTime created, string firstName, string lastName)
        {
            ID = id;
            Created = created;
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetLogMessage() // required by ILoggable
        {
            return $"User name: {FirstName} {LastName}";
        }

    }
}
