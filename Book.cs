namespace GruppProjectBibliotek
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string author, int isbn ,int isCheckedOut) // The parametres of the class Book (Duuh) for when to create a new object. Self checkout coming February 30th
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

        public void DoesBookExist() // A method to look up if we have said book! My dementia have been acting up lately... 
        {

            bool doesItExist = false;
            string bookTitle;

            while (doesItExist == false)
            {

                Console.WriteLine("Write the title and thou program shalt tell if we have it!");
                bookTitle = Console.ReadLine();

                if (bookTitle == Title) // "HELL YEAH" should be the reaction if this happens
                {

                    Console.WriteLine("This library is awesome and have this book, you are welcome!");

                    doesItExist = true;
                    break;

                }
                else if (bookTitle == null) // In case someone is illiterate #SpreadAwareness
                {

                    Console.WriteLine("Dude. You need to type something so we can look this up for you...");
                    break;

                }
                else // Sucks to suck on this one =)
                {

                    Console.WriteLine("Either you wrote wrong or this library is way too cool for that book!");
                    continue;

                }
            }
        }
    }
}