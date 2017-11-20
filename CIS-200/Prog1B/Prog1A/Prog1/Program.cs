// Program 1B
// CIS 200-01
// Due: 2/22/2017
// By: D2214

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9B", 16, 8));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9C", 16, 9));
        items.Add(new LibraryMagazine("VB Magazine", "UofL Mags", 2017, 14,
            "MA21 5V", 1, 1));

        //Display before check out
        Console.WriteLine("Before checked out:-----------------------------");
        Console.WriteLine("");
        foreach (LibraryItem item in items)
        {
            Console.WriteLine(item);
            Console.WriteLine("------------------------------------------------");
        }

        Console.WriteLine("");
        Console.WriteLine("...");
        Pause();
        Console.WriteLine("");

        // Add patrons
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));
        patrons.Add(new LibraryPatron("John Smith", "54321"));
        patrons.Add(new LibraryPatron("James T. Kirk", "98765"));
        patrons.Add(new LibraryPatron("Jean-Luc Picard", "33456"));


        // Check out some items
        items[0].CheckOut(patrons[0]);
        items[2].CheckOut(patrons[2]);
        items[5].CheckOut(patrons[1]);
        items[1].CheckOut(patrons[3]);
        items[4].CheckOut(patrons[4]);


        //Print the checked  out
        Console.WriteLine("Checked Out:");
        Console.WriteLine("");

        foreach (LibraryItem item in items)
        {
            if (item.IsCheckedOut())
            {
                Console.WriteLine(item + Environment.NewLine);
                Console.WriteLine("------------------------------------------------");
            }
        }

        Pause();



        //LINQ for items that are checked out
        var selectall =
        from item in items
        where item.IsCheckedOut()
        select item;


        //Print All that are checked out
        Console.WriteLine("Checked out:");
        Console.WriteLine("--------------------------------");
        foreach (LibraryItem item in selectall)
        {
            Console.WriteLine(item);
            Console.WriteLine("--------------------------------");
        }
        //Display count
        Console.WriteLine(selectall.Count());

        Pause();

        //LINQ for LibraryMediaItems that are checked out
        var mediaitemcheckedout =
            from item in selectall
            where item is LibraryMediaItem
            select item;

        //Print the library media items that are checked out
        Console.WriteLine("Library Media Items Checked Out:");
        Console.WriteLine("");
        foreach (LibraryItem item in mediaitemcheckedout)
        {
            Console.WriteLine(item);
            Console.WriteLine("----------------------------------");
        }

        Pause();


        //LINQ Unique Titles
        var uniquetitles =
            from item in items
            where item is LibraryMagazine
            select item.Title;

        //Print all magazines with unique titles.
        Console.WriteLine("Library Magazines:");
        Console.WriteLine("");
        foreach (var element in uniquetitles.Distinct())
        {
            Console.WriteLine(element);                    
            Console.WriteLine("----------------------------------");
        }

        Pause();


        //If late 14 Days
        foreach (LibraryItem item in items)
        {
            //Holder for days late
            const int DAYS_LATE = 14;

            item.LoanPeriod += DAYS_LATE;
            Console.WriteLine($"${item.LoanPeriod}");
        }
        Pause();

        //Return each item that is checked out
        foreach (LibraryItem item in items)
        {
            if (item.IsCheckedOut())
                item.ReturnToShelf();
        }
        

        //Print number of items that are now checked out.
        Console.WriteLine("Checked out:");
        Console.WriteLine(selectall.Count());
        Pause();


        //Test if its a library book, if so, print and then add days. 
        foreach (LibraryItem item in items)
        {
            //Constant for days to add
            const int ADD_DAYS = 7;
             
            if (item is LibraryBook)
            {
                Console.WriteLine(item.LoanPeriod);
                Console.WriteLine($"{item.Title} loan period changed to {item.LoanPeriod + ADD_DAYS}");
            }
        }
        Pause();


        //Final display of all the items.
        foreach(LibraryItem item in items)
        {
            Console.WriteLine(item);
            Console.WriteLine("------------------------------------------------");
        }
        Pause();
    }


    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();

        Console.Clear(); // Clear screen
    }


}
