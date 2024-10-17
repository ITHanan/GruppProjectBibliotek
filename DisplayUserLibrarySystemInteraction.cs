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
                        //string titletoAddBook = Console.ReadLine()!;
                        library.AddBook(/*titletoAddBook*/);
                        break;
                    case 2:                           
                        library.RemoveBook(/*titletoRemoveBook*/);
                        break;
                    case 3:
                        library.SearchBook();
                        break;
                    case 4:
                        library.DisplayAllBooks();
                        break;
                    case 5:
                        //  string titletoCheckOutBook = Console.ReadLine()!;
                        library.CheckOutBook(/*titletoCheckOutBook*/);
                        break;
                    case 6:
                        //  string titletoReturnBook = Console.ReadLine()!;
                        library.ReturnBook(/*titletoReturnBook*/);
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
