
namespace exception_user
{
    internal class User
    {
        public User(string name, string email, int yearOfBirth)
        {
            Name = name;
            Email = email;
            YearOfBirth = yearOfBirth;
        }

        public string Name { get; }
        public string Email { get; }
        public int YearOfBirth { get; }

        public override string ToString()
        {
            return $"{Name}, {Email}, year of birth: {YearOfBirth}";
        }

    }
}
