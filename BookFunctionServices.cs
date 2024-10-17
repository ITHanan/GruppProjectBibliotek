using System.Reflection;

namespace GruppProjectBibliotek
{
    public class BookFunctionServices
    {
        public List<Book> books = new List<Book>();  // List of books

        //Search for books based on the titl
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
      public void SearchBook(string title)
        {
            Console.WriteLine("Enter the title of the book you want to search: ");

             List<Book> foundBooks = books.FindAll(b => b.Title.ToLower().Contains(title.ToLower()));

            if (foundBooks.Count > 0)
            {
                Console.WriteLine("BOOKS FOUND");
                foreach (Book book in foundBooks)
                {
                    book.DisplayBookInfo();
                }
            }
            else
            {
                Console.WriteLine("No books found by that author.");
            }
        }


        // Return a book
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