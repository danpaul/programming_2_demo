using System.Collections;

namespace array_list
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
            // DON'T USE THIS!!! ArrayList is an outdated data structure
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add("3"); // inconsistent data type

            foreach (int i in list) // runtime error!
            {
                Console.WriteLine(i);
            }

            // List is typed
            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add("3"); // phew! build time error,
                            // we'll have to fix this before the program runs

            // List<List<int>> myListList = new List<List<int>>(); 

            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
