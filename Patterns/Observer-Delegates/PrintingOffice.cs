namespace Observer_Delegates;

public class PrintingOffice
{
    public event BookPrintedEventArgs BookPrintedEvent;

    public void PrintBooks(int bookCount)
    {
        for (int i = 0; i < bookCount; i++)
        {
            PrintOneBook();
        }
    }

    private void PrintOneBook()
    {
        Book book = new Book();
        book.Genre = "Action";
        book.Title = "Test";
        book.Pages = 10;

        OnBookPrinted(book);
    }

    protected virtual void OnBookPrinted(Book book)
    {
        BookPrintedEvent?.Invoke(book);
    }
}