using GruppProjectBibliotek;

class Program
{
    static void Main(string[] args)
    {
        LibrarySystem library = new LibrarySystem();
        DisplayUserLibrarySystemInteraction displayMenu = new DisplayUserLibrarySystemInteraction(library);
        displayMenu.RunSystem();
    }
}
