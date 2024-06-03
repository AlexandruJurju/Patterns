namespace Observer_Delegates;

class Program
{
    static void Main(string[] args)
    {
        PrintingOffice printingOffice = new PrintingOffice();
        BookLover bookLover = new BookLover("James", printingOffice);
        printingOffice.PrintBooks(1);
    }
}