namespace file_append
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Example1();
            program.Example2();
            Console.WriteLine("done");
        }

        // Example file write without append mode enabled
        void Example1()
        {
            StreamWriter streamWriter = new StreamWriter("../../../example1.txt");
            streamWriter.WriteLine("message1");
            streamWriter.WriteLine("message2");
            streamWriter.WriteLine("message3");
            streamWriter.Close();

            streamWriter = new StreamWriter("../../../example1.txt");
            streamWriter.WriteLine("message4");
            streamWriter.WriteLine("message5");
            streamWriter.WriteLine("message6");
            streamWriter.Close();
        }

        // Example file write with append mode enabled
        void Example2()
        {
            StreamWriter streamWriter = new StreamWriter("../../../example2.txt", true);
            streamWriter.WriteLine("message1");
            streamWriter.WriteLine("message2");
            streamWriter.WriteLine("message3");
            streamWriter.Close();

            streamWriter = new StreamWriter("../../../example2.txt", true);
            streamWriter.WriteLine("message4");
            streamWriter.WriteLine("message5");
            streamWriter.WriteLine("message6");
            streamWriter.Close();
        }
    }
}
