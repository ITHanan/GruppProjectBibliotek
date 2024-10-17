namespace GruppProjectBibliotek
{
    public class LibrarySystem
    {
    public BookFunctionCore BookCore { get; }
    public BookFunctionServices BookService { get; }
    public List<Book> Books { get; private set; }

        public LibrarySystem()
        {
            Books = new List<Book>();
            BookCore = new BookFunctionCore(Books);
            BookService = new BookFunctionServices(Books);
        }
        
        public void AddBook()
        {
            BookCore.AddBook(); 
        }
        public void RemoveBook()
        {
            BookCore.RemoveBook(); 
        }
        public void DisplayAllBooks()
        {
            BookCore.DisplayAllBooks(); 
        }
        public void SearchBook(string title)
        {
            BookService.SearchBook(title); 
        }
        public void CheckOutBook(string title)
        {
            BookService.CheckOutBook(title);
        }

        public void ReturnBook(string title)
        {
            BookService.ReturnBook(title);
        }
    }
}