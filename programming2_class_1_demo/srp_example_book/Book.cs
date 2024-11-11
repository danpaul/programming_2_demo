using System;

namespace srp_example_book;

// This example shows a class that violates SRP by mixing data modeling and persistence operations
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void SaveBook()
    {
        Console.WriteLine("Saving book to database...");
    }

    public void LoadBook()
    {
        Console.WriteLine("Loading book from database...");
    }
}

