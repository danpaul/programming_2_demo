namespace generic_example
{
    // NOTE! DEMO ONLY, normally we always put classes in separate files

    // Generic class definition
    public class Box<T>
    {
        // Generic field to hold a value
        private T item;

        // Generic property to get or set the value
        public T Item
        {
            get { return item; }
            set { item = value; }
        }

        // Generic method to display the item
        public void DisplayItem()
        {
            Console.WriteLine($"The item is: {item}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Box instance for an integer
            Box<int> intBox = new Box<int>();
            intBox.Item = 42;
            intBox.DisplayItem();

            // Create a Box instance for a string
            Box<string> stringBox = new Box<string>();
            stringBox.Item = "Hello, Generics!";
            stringBox.DisplayItem();
        }
    }
}
