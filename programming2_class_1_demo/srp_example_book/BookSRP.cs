using System;

namespace srp_example_book;

public class BookModel
{
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor
    public BookModel(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

public class BookRepository
{
    public void SaveBook(BookModel book)
    {
        Console.WriteLine($"saving book '{book.Title}' by {book.Author} to database...");
    }

    public BookModel LoadBook(string title)
    {
        Console.WriteLine($"Loading book '{title}' from database...");
        return new BookModel(title, "Sample Author");
    }
}