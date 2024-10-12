using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace GruppProjectBibliotek
{
    public class BookFunctionCore
    {
       

         List<Book> Library = new List<Book>();




        public void AddBook() 

        {
            Console.WriteLine("Welcome to My beautiful Library. Pleas Enter the book title:\n");

            String title = Console.ReadLine()!;

            Console.WriteLine("Excellent, now enter the author's name:\n");

            String author = Console.ReadLine()!;

            Console.WriteLine("Great, now Enter ISBN code:\n");

            String isbnString = Console.ReadLine()!;

            int isbn = Convert.ToInt32(isbnString);

            if (title == null || author == null || isbn == 0) 
            {
                Console.WriteLine("Somethimg went wrong. Please enter all required data");
                return;
            }

            Library.Add(new Book(title, author, isbn));

            Console.WriteLine($"The book{title} has been successsfully entered");
        }






        public void RemoveBook()
        {
            Console.WriteLine("Pleas Enter the title of the book that you to remove:");

            string title = Console.ReadLine()!;

            Book  removingTheBook = null;

            foreach (Book book in Library)
            {
                if (book.Title == title)
                {
                    removingTheBook = book;
                }

                else if (removingTheBook != null)
                {
                    Library.Remove(removingTheBook);
                    Console.WriteLine($"The book {title} has been deleted ");

                }
                else 
                {
                    Console.WriteLine($"Something went wrong the Book {title} cannot be found.");
                }
                
            }

        }

        public void DisplyAllBook()
        {
            if (!Library.Any())
            {
                Console.WriteLine("Ther are no books in th library\n");
                return;
            }

            Console.WriteLine("This is a list of all the books in the library ");
            foreach (Book book in Library) 
            {
            book.DisplayBookInfo();
            }
        }
        




    }
}