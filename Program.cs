using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppProjectBibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            LibrarySystem library = new LibrarySystem();
            DisplayUserLibrarySystemInteraction userInterface = new DisplayUserLibrarySystemInteraction(library);
            userInterface.RunSystem();
        }
    }
}
