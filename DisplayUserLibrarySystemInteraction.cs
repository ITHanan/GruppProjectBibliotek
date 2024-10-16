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
                
                if (int.TryParse(userInput, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            //string titletoAddBook = Console.ReadLine()!;
                            library.AddBook(/*titletoAddBook*/);
                            Console.WriteLine("AddBook function");
                            break;
                        case 2:
                            Console.WriteLine("RemoveBook function");
                           
                            library.RemoveBook(/*titletoRemoveBook*/);
                            break;
                        case 3:
                            Console.WriteLine("SearchBook function");
                          
                            library.SearchBook();
                            break;
                        case 4:
                            Console.WriteLine("DisplayAllBook function");

                            library.DisplayAllBooks();
                            break;
                        case 5:
                            Console.WriteLine("CheckOutBook function");
                          //  string titletoCheckOutBook = Console.ReadLine()!;
                            library.CheckOutBook(/*titletoCheckOutBook*/);
                            break;
                        case 6:
                            Console.WriteLine("ReturnBook function");
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
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    } //End of class DisplayUserLibrarySystemInteraction
}
