namespace exceptions_types
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {

            // IndexOutOfRangeException
            try
            {
                
                int[] array = { 1, 2, 3 };
                // int index = int.Parse(Console.ReadLine());
                // Console.WriteLine(array[index]);
                Console.WriteLine(array[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"ArgumentOutOfRangeException: {ex.Message}");
            }

            // DivideByZeroException
            try
            {
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivideByZeroException: {ex.Message}");
            }

            // FormatException
            try
            {
                string input = "abc";
                int number = int.Parse(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException: {ex.Message}");
            }

            // KeyNotFoundException
            try
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                int value = dictionary["missingKey"];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"KeyNotFoundException: {ex.Message}");
            }

            // OverflowException
            try
            {
                checked
                {
                    int max = int.MaxValue;
                    int result = max + 1;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"OverflowException: {ex.Message}");
            }

            // FileNotFoundException
            try
            {
                string content = File.ReadAllText("nonexistent.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"FileNotFoundException: {ex.Message}");
            }


        }
    }

}
