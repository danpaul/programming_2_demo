namespace list_methods_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            keyListMethodsAndProperties();
            additionalListMethodsAndProperties();

        }

        // demonstrates the most commonly used list methods and properties
        static void keyListMethodsAndProperties()
        {
            // create a new list
            List<int> list = new List<int>();

            // alternatively, create a new list with elements
            // List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            // add additional elements to list
            Console.WriteLine("Adding 10, 20, 30, 40 to the list");
            list.Add(10);
            //
            list.Add(20);
            list.Add(30);
            list.Add(40);

            // check how many elements are in the list using the .Count property
            Console.WriteLine($"The list has {list.Count} elements\n");

            // read a list element using square bracket (array) syntax
            Console.WriteLine($"The last element of the list is: {list[list.Count - 1]}\n");

            // update a list element
            Console.WriteLine("Updating the 4th element (at index 3) to 44");
            list[3] = 44;
       

            // check if list contains an element
            bool listContains44 = list.Contains(44);
            Console.WriteLine($"The list contains the number 44: {listContains44}\n");

            // loop through the list using a for loop and the .Count property
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"The {i + 1} element of the list is: {list[i]}");
            }
            Console.WriteLine();

            // remove the last element from the list
            Console.WriteLine("Removing the last element of the list\n");
            list.RemoveAt(list.Count - 1);

            // loop through the loop using a foreach loop
            Console.WriteLine("Updated list:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

        }

        // demonstrates some additional methods and properties
        static void additionalListMethodsAndProperties()
        {

            // Create a new list
            List<int> numbers = new List<int>();

            // 1. Adding Elements
            numbers.Add(10);                     // Add single element
            numbers.AddRange(new int[] { 20, 30, 40 }); // Add a range of elements
            Console.WriteLine("After Adding: " + string.Join(", ", numbers));

            // 2. Accessing Elements
            Console.WriteLine("First Element: " + numbers[0]);  // Access by index
            numbers[1] = 25;  // Modify an element
            Console.WriteLine("After Modification: " + string.Join(", ", numbers));

            // 3. Removing Elements
            numbers.Remove(25);          // Remove the first occurrence of 25
            Console.WriteLine("After Removing 25: " + string.Join(", ", numbers));
            numbers.RemoveAt(2);         // Remove the element at index 2
            Console.WriteLine("After Removing at Index 2: " + string.Join(", ", numbers));
            numbers.AddRange(new int[] { 50, 60 });
            numbers.RemoveRange(1, 2);   // Remove a range starting at index 1
            Console.WriteLine("After Removing Range: " + string.Join(", ", numbers));

            // 4. Searching and Checking
            Console.WriteLine("Contains 10? " + numbers.Contains(10)); // Check existence
            Console.WriteLine("Index of 10: " + numbers.IndexOf(10));  // Find index
            Console.WriteLine("Last Index of 10: " + numbers.LastIndexOf(10));
            Console.WriteLine("Exists > 40? " + numbers.Exists(n => n > 40)); // Custom check

            // 5. Finding Elements
            numbers.AddRange(new int[] { 70, 80, 90 });
            int firstLarge = numbers.Find(n => n > 40); // Find first match
            Console.WriteLine("First > 40: " + firstLarge);
            List<int> allLarge = numbers.FindAll(n => n > 40); // Find all matches
            Console.WriteLine("All > 40: " + string.Join(", ", allLarge));

            // 6. Iterating
            Console.WriteLine("Iterating over list:");
            numbers.ForEach(n => Console.WriteLine(n));

            // 7. Sorting
            numbers.Sort();  // Ascending sort
            Console.WriteLine("After Sort: " + string.Join(", ", numbers));
            numbers.Sort((a, b) => b.CompareTo(a)); // Descending sort
            Console.WriteLine("After Descending Sort: " + string.Join(", ", numbers));

            // 8. Conversions
            int[] numberArray = numbers.ToArray(); // Convert to array
            Console.WriteLine("Array: " + string.Join(", ", numberArray));

            // 9. Capacity Management
            Console.WriteLine("Count: " + numbers.Count);       // Number of elements
            Console.WriteLine("Capacity: " + numbers.Capacity); // Internal capacity
            numbers.TrimExcess();                              // Optimize capacity
            Console.WriteLine("Capacity after TrimExcess: " + numbers.Capacity);

            // 10. Inserting Elements
            numbers.Insert(1, 100);             // Insert element at index 1
            numbers.InsertRange(2, new int[] { 200, 300 }); // Insert range at index 2
            Console.WriteLine("After Insertions: " + string.Join(", ", numbers));

            // 11. Clearing Elements
            numbers.Clear(); // Remove all elements
            Console.WriteLine("After Clear, Count: " + numbers.Count);

        }

    }
}
