
namespace serialization_simple
{
    internal class User
    {
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public static string Serialize(User user)
        {
            return $"{user.Name},{user.Age}";
        }

        public static User Deserialize(string userString)
        {
            string[] userData = userString.Split(',');
            return new User(userData[0], int.Parse(userData[1]));
        }
    }
}
