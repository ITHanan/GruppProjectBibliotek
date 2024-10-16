namespace GruppProjectBibliotek
{
    class BookFunctionServices
    {
        private List<Book> books = new List<Book>();  // List of books

        // Search for books based on the title
        public List<Book> SearchBook(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Error: The title cannot be empty or contain only whitespace.");
                return new List<Book>();  // Return an empty list for invalid input
            }

            var foundBooks = books
                .Where(book => book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"No books found with the title \"{title}\".");
            }
            else
            {
                Console.WriteLine($"Found {foundBooks.Count} book(s):");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author}");
                }
            }

            return foundBooks;
        }

        // Check out a book based on the title
        public void CheckOut(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Error: The title cannot be empty or contain only whitespace.");
            }
            else
            {
                Book book = Find(title);
                if (book == null)  // Check if the book is not found
                {
                    Console.WriteLine($"Error: The book \"{title}\" was not found.");
                }
                else if (book.IsCheckedOut)
                {
                    Console.WriteLine($"The book \"{book.Title}\" is already checked out.");
                }
                else
                {
                    book.IsCheckedOut = true;
                    Console.WriteLine($"The book \"{book.Title}\" has been checked out.");
                }
            }
        }

        // Return a book
        public void ReturnBook(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Error: The title cannot be empty or contain only whitespace.");
            }
            else
            {
                Book book = Find(title);
                if (book == null)  // Check if the book is not found
                {
                    Console.WriteLine($"Error: The book \"{title}\" was not found.");
                }
                else if (!book.IsCheckedOut)
                {
                    Console.WriteLine($"The book \"{book.Title}\" is already returned.");
                }
                else
                {
                    book.IsCheckedOut = false;
                    Console.WriteLine($"The book \"{book.Title}\" has been returned.");
                }
            }
        }

        private Book Find(string title)
        {
            // Return the first matching book or null if not found
            return books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}