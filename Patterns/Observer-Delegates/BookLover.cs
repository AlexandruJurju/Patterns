namespace Observer_Delegates;

public class BookLover
{
    private readonly string _name;

    public BookLover(string name, PrintingOffice printingOffice)
    {
        _name = name;
        printingOffice.BookPrintedEvent += HandleNewBook;
    }
    
    private void HandleNewBook(Book book)
    {
        Console.WriteLine($"BookLover: {_name} has been notified that a new book with TITLE: {book.Title} has been released");
    }
}