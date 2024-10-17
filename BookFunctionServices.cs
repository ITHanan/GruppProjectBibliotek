using System.Reflection;

namespace GruppProjectBibliotek
{
    public class BookFunctionServices
    {
        public List<Book> books = new List<Book>();  

        public BookFunctionServices(List<Book> sharedBooks)
        {
            books = sharedBooks;
        }

    public void CheckOutBook(string title)
        {
            Book bookToCheckOut = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))!;
            if (bookToCheckOut != null)
            {
                if (bookToCheckOut.IsCheckedOut)
                {
                    Console.WriteLine("Book is already checked out.");
                }
                else
                {
                    bookToCheckOut.IsCheckedOut = true;
                    Console.WriteLine("Book checked out successfully.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        
        public List<string> SearchBook(string title)
        {
            List<Book> foundSearchedBooks = books.Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
            
            if (foundSearchedBooks.Count > 0)
            {
                Console.WriteLine($"Found {foundSearchedBooks.Count} book(s) with that title:");
                foreach (Book book in foundSearchedBooks)
                {
                    book.DisplayBookInfo();
                }
            }
            else
            {
                Console.WriteLine("No books found by that title.");
            }
            
            return foundSearchedBooks.Select(b => b.Title).ToList();
        }

       public void ReturnBook(string title)
        {
            Book bookToReturn = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))!;
            if (bookToReturn != null)
            {
                if (bookToReturn.IsCheckedOut)
                {
                    bookToReturn.IsCheckedOut = false;
                    Console.WriteLine("Book returned successfully.");
                }
                else
                {
                    Console.WriteLine("Book is not checked out.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}