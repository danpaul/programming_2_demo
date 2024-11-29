
namespace dictionary_students
{
    internal class Student
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Name}, phone: {Phone}";
        }
    }
}
