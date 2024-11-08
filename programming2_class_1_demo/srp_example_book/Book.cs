using System;

namespace srp_example_book;

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

