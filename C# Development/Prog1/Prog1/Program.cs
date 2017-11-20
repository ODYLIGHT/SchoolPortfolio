//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This is a test program for library items. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {


            LibraryMovie pokemonmovie = new LibraryMovie("Pokemon", "Jack Frost", 2009, 13, "under the bed", 2.35, "Stephen Hawking", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG13);
            LibraryMusic starboy = new LibraryMusic("asdf", "Jesus Himself", 2018, 70200, "Library", 1.53, "The Weekend", LibraryMediaItem.MediaType.CD, 13);
            LibraryJournal news = new LibraryJournal("Times", "Times Incorporated", 2015, 30, "Coffee Table or Bathroom", 2,13, "Medicine", "John Cusack");
            LibraryBook bible = new LibraryBook("The bibble", "Who knows.", "Greedy Peeps", 2346, 12, "Everywhere");
            LibraryMagazine caranddriver = new LibraryMagazine("2017 Car of the Year", "Car and Driver", 2017, 7, "Top Shelf", 2, 13);
            LibraryMovie departed = new LibraryMovie("The Departed", "Brothers", 2006, 14, "Movie section", 2.2, "Scorcese", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.R);


            List<LibraryItem> LibraryItems = new List<LibraryItem> { pokemonmovie, starboy, news, bible, caranddriver, departed };

            foreach (LibraryItem i in LibraryItems)
            {
                Console.WriteLine(i);
                Console.WriteLine();

            }



            //        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            //2010,12, "ZZ25 3G");  // 1st test book
            //        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            //            2000,13, "AG773 ZF"); // 2nd test book
            //        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            //            1985,14, "JJ438 4T"); // 3rd test book
            //        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            //            2017,15, "ZZ24 4F");  // 4th test book
            //        LibraryBook book5 = new LibraryBook("    The Big Book of Doughnuts   ", "   Homer Simpson   ", "   Doh Books   ",
            //            2001,16, "   AE842 7A   "); // 5th test book - Trims?
            //        LibraryMagazine mag1 = new LibraryMagazine("Car and Driver", "Sean Sheen", 3, 14, "Top shelf", 3, 4);

            //        LibraryPatron patron1 = new LibraryPatron("Ima Reader", "123456"); // 1st test patron
            //        LibraryPatron patron2 = new LibraryPatron("Jane Doe", "112233");  // 2nd test patron
            //        LibraryPatron patron3 = new LibraryPatron("   John Smith   ", "   654321   "); // 3rd test patron - Trims?


            //        Console.WriteLine(mag1.ToString());
            //        List<LibraryBook> theBooks = new List<LibraryBook>(); // Test list of books

            //        // Add books to the list
            //        theBooks.Add(book1);
            //        theBooks.Add(book2);
            //        theBooks.Add(book3);
            //        theBooks.Add(book4);
            //        theBooks.Add(book5);


            //        Console.WriteLine("Original list of books");
            //        PrintBooks(theBooks);

            //        // Make changes
            //        book1.CheckOut(patron1);
            //        book2.Publisher = "Borrowed Books";
            //        book3.CheckOut(patron2);
            //        book4.CallNumber = "AB123 4A";
            //        book5.CheckOut(patron3);

            //        Console.WriteLine("After changes");
            //        PrintBooks(theBooks);

            //        // Return all the books
            //        for (int i = 0; i < theBooks.Count; ++i)
            //            theBooks[i].ReturnToShelf();

            //        Console.WriteLine("After returning the books");
            //        PrintBooks(theBooks);
            //    }

            //    // Precondition:  None
            //    // Postcondition: The books have been printed to the console
            //    public static void PrintBooks(List<LibraryBook> books)
            //    {
            //        foreach (LibraryBook b in books)
            //        {
            //            Console.WriteLine(b);
            //            Console.WriteLine();
            //        }
        }
    }
}
