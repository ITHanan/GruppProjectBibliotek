namespace GruppProjectBibliotek
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string author, int isbn, bool isCheckedOut) // The parametres of the class Book (Duuh) for when to create a new object. Self checkout coming February 30th
        {

            Title = title;
            Author = author;
            Isbn = isbn;
            IsCheckedOut = isCheckedOut;


        }

        public void DisplayBookInfo() // To get info (NO WAY?!). Should be used with a foreach loop for the List we are creating but who am I to decide... There's no I in our team (If we don't count 2 group members)
        {

            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nISBN: {Isbn}\nChecked Out: {IsCheckedOut}");

        }

    }
}