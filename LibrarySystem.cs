namespace GruppProjectBibliotek
{
    public class LibrarySystem
    {
      
        private BookFunctionCore bookCore; 
        private BookFunctionServices bookService;
        public List<Book>books = new List<Book>();

        public LibrarySystem()
        {
            books= new List<Book>();
            bookCore = new BookFunctionCore(); 
            bookService = new BookFunctionServices(); 
        }

       
        public void AddBook()
        {
            bookCore.AddBook(); 
        }

        
        public void RemoveBook()
        {
            bookCore.RemoveBook(); 
        }

        
        public void DisplayAllBooks()
        {
            bookCore.DisplayAllBooks(); 
        }

       
        public void SearchBook(string title)
        {
           // bookService.SearchBook(title); 
        }

       
        public void CheckOutBook(string title)
        {
           // bookService.CheckOut(title);
        }

        
        public void ReturnBook(string title)
        {
            // bookService.ReturnBook(title); 
        }
    }
}
