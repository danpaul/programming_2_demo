namespace war_and_peace
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
             SpeedRead();
           //  Misread();
        }

        void SpeedRead()
        {
            const string file = "../../../war_and_peace.txt";
            StreamReader streamReader = new StreamReader(file);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
            }
            streamReader.Close();

            // equivalent to above but does not requre closing the StreamReader
            using (StreamReader streamReader2 = new StreamReader(file)) {
                while (!streamReader2.EndOfStream)
                {
                    string line = streamReader2.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }

        void Misread()
        {

            try
            {
                StreamReader streamReader = new StreamReader("../../../war_and_pieces.txt");
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
                streamReader.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An IO exception occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unkown exception occurred");
            }

        }
    }
}
