namespace GruppProjectBibliotek
{
    public class DisplayUserLibrarySystemInteraction
    {
        LibrarySystem library = new LibrarySystem();
        public DisplayUserLibrarySystemInteraction(LibrarySystem lib) //Constructor
        {
            this.library = lib;
        }
         public void DisplayMenu()
        {
            Console.WriteLine("\n------ Library Menu ------");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Check Out Book");
            Console.WriteLine("6. Return Book");
            Console.WriteLine("0. Exit");
        }

        public void RunSystem()
        {
            bool running = true;
            while (running)
            {
                DisplayMenu();
                string userInput = Console.ReadLine()!;
                int userInputInt = int.Parse(userInput);

                switch (userInputInt)
                {
                    case 1:
                        library.AddBook();
                        break;
                    case 2:  
                        library.RemoveBook();
                        break;
                    case 3:
                        Console.WriteLine("Enter the title of the book you want to search:");
                    string titleToSearch = Console.ReadLine()!;
                        library.SearchBook(titleToSearch);
                        break;
                    case 4:
                        library.DisplayAllBooks();
                        break;
                    case 5:
                        Console.WriteLine("Enter the title of the book you want to check out:");
                        string titleToCheckOut = Console.ReadLine()!;
                        library.CheckOutBook(titleToCheckOut);
                    break;
                    case 6:
                        Console.WriteLine("Enter the title of the book you want to return:");
                        string titleToReturn = Console.ReadLine()!;
                        library.ReturnBook(titleToReturn);
                    break;
                    case 0:
                        Console.WriteLine("Exit...");
                        running = false;
                        break;
                    default:    
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;
                }
                
                Console.WriteLine("Vill du fortsätta? (J/N)");
                string continueChoice = Console.ReadLine()!;
                if (continueChoice.ToUpper() == "N")
                {
                    running = false;
                }           
            }
        }
    } //End of class DisplayUserLibrarySystemInteraction
}
