namespace srp_example_book;

class Program
{
    static void Main(string[] args)
    {
        // This book class violates SRP since it is responsible for both defining
        // the structure of book data and handling database operations (saving the book)
        Book catcherInTheRye = new Book() { Title = "Catcher in the Rye", Author = "J.D. Salinger" };
        catcherInTheRye.SaveBook();

        // By separating the concerns of book data and data persistence, we are better 
        // able to achieve a good separation of concerns
        BookModel crimeAndPunishment = new BookModel("Crime and Punishment", "Fyodor Dostoevsky");
        BookRepository bookRepository = new BookRepository();
        bookRepository.SaveBook(crimeAndPunishment);
    }
}
