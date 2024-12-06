namespace exception_catch_chaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { 1, 2, 3 };
                Console.Write("Enter an index: ");
                // what happens if the user enters something that is not a number?
                // what happens if the user enters an index outside the array bounds?
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(array[index]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Caught the IndexOutOfRangeException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught a {ex.GetType()} exception: {ex.Message}");
            }
        }
    }
}
