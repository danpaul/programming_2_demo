namespace dictionary_students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a dictionary of students, the int key represents the sudent id
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            // var students = new Dictionary<int, Student>(); // alternative declaration

            Student dave = new Student() { Name = "Dave", Phone = "2127777777" };
            Student jill = new Student() { Name = "Jill", Phone = "2128888888" };

            // define a constant to use as student dave's student id
            const int DavesStudentID = 135874;

            // add student to dictionary
            students.Add(DavesStudentID, dave);

            // to safely add or update, we can use array syntax
            students[DavesStudentID] = dave;

            // check if key exists
            if (students.ContainsKey(DavesStudentID))
            {
                Console.WriteLine($"The dictionary contains this key already. The value is: {students[DavesStudentID]}");
            }

            // this would results in a runtime error:
            // students.Add(DavesStudentID, dave);

        }
    }
}
