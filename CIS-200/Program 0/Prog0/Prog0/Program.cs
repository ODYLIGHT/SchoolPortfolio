//Program 4
//CIS 200-01
//Due 11/30/2017
//By: D2214

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            100, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book

        List<LibraryBook> theBooks = new List<LibraryBook>() { book1, book2, book3, book4, book5  }; // Initialization of List and it's collection

        Console.WriteLine("Original list of books");
        PrintBooks(theBooks);

        //3 Patron object created to test the program
        LibraryPatron patron1 = new LibraryPatron("Peter Gregorio", "12234");
        LibraryPatron patron2 = new LibraryPatron("Jerry Seinfeld", "54321");
        LibraryPatron patron3 = new LibraryPatron("Other Person", "00000");

        // Make changes by passing the patron objects to the checkout method to check out the library books!
        book1.CheckOut(patron1);
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(patron2);
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron3);

        Console.WriteLine("After changes");
        PrintBooks(theBooks);

        // Return all the books
        for (int i = 0; i < theBooks.Count; ++i)
            theBooks[i].ReturnToShelf();

        Console.WriteLine("After returning the books");
        PrintBooks(theBooks);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> books)
    {
        foreach (LibraryBook b in books)
        {
            Console.WriteLine(b);
            Console.WriteLine();
        }
    }
}
