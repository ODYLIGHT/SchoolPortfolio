// Program 5
// CIS 200-01
// Due: 4/25/2017
// By: D2214

// File: Library.cs
// This file creates a basic Library class that stores a list
// of LibraryItems and a list of LibraryPatrons. It allows items
// to be checked out by patrons. The lists are accessible to other
// classes in the same namespace (LibraryItems).
// Now Serializable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    [Serializable]
    public class Library 
    {
        // Namespace Accessible Data - Use with care
        internal List<LibraryItem> _items;     // List of items stored in Library
        internal List<LibraryPatron> _patrons; // List of patrons of Library

        Dictionary<string, LibraryItem> libraryItems = new Dictionary<string, LibraryItem>();
        Dictionary<string, LibraryPatron> libraryPatrons = new Dictionary<string, LibraryPatron>();
        Dictionary<string, DateTime> transactions = new Dictionary<string, DateTime>();

        private bool SUCCESSFUL_ADD = true;
        private bool FAILED_ADD = false; 

        // Precondition:  None
        // Postcondition: The library has been created and is empty (no books, no patrons)
        public Library()
        {
            _items = new List<LibraryItem>();
            _patrons = new List<LibraryPatron>();
        }

        // Precondition:  None
        // Postcondition: A patron has been created with the specified values for name and ID.
        //                The patron has been added to the Library.
        public bool AddPatron(String patronId, String name)
        {
            LibraryPatron newPatron = new LibraryPatron(name, patronId);

            if (libraryPatrons.ContainsKey(patronId))
            {
                Console.WriteLine("didn't work");
                return FAILED_ADD;
            }
            else
            {
                libraryPatrons.Add(patronId, newPatron);
                Console.WriteLine("it did work");
                return SUCCESSFUL_ADD;
            }
        }
        
        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0
        // Postcondition: A library book has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, and author. The item is not checked out.
        //                The book has been added to the Library.
        public bool AddLibraryBook(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, String theAuthor)
        {
            // create the new boook
            LibraryBook newBook = new LibraryBook(theTitle, thePublisher, theCopyrightYear,
             theLoanPeriod, theCallNumber, theAuthor);

            // item callnum doesn't exist 
            if (!libraryItems.ContainsKey(theCallNumber))
            {
                // add the book to dict
                libraryItems.Add(theCallNumber, newBook);

                _items.Add(new LibraryBook(theTitle, thePublisher, theCopyrightYear, theLoanPeriod,
                    theCallNumber, theAuthor));
                return SUCCESSFUL_ADD;
            }
            else
            {
                return FAILED_ADD;
            }

        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0 and 
        //                theMedium from { DVD, BLURAY, VHS } and theDuration >= 0
        // Postcondition: A library movie has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, duration, director, medium, and rating. The
        //                item is not checked out.
        //                The movie has been added to the Library.
        public bool AddLibraryMovie(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, double theDuration, String theDirector,
            LibraryMediaItem.MediaType theMedium, LibraryMovie.MPAARatings theRating)
        {
            // create the new movie object
            LibraryMovie newMovie = new LibraryMovie(theTitle, thePublisher, theCopyrightYear,
             theLoanPeriod, theCallNumber, theDuration, theDirector,
             theMedium, theRating);

            // does the callnum exist already?
            if (!libraryItems.ContainsKey(theCallNumber))
            {
                // add the movie to the dict
                libraryItems.Add(theCallNumber, newMovie);

                _items.Add(new LibraryMovie(theTitle, thePublisher, theCopyrightYear, theLoanPeriod,
                    theCallNumber, theDuration, theDirector, theMedium, theRating));

                return SUCCESSFUL_ADD;
            }
            else
            {
                return FAILED_ADD;
            }
        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0 and 
        //                theMedium from { CD, SACD, VINYL } and theDuration >= 0 and
        //                theNumTracks >= 0
        // Postcondition: A library music item has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, duration, director, medium, and rating. The
        //                item is not checked out.
        //                The music item has been added to the Library.
        public bool AddLibraryMusic(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, double theDuration, String theArtist,
            LibraryMediaItem.MediaType theMedium, int theNumTracks)
        {
            // new music object
            LibraryMusic newMusic = new LibraryMusic(theTitle, thePublisher,  theCopyrightYear,
             theLoanPeriod,  theCallNumber,  theDuration,  theArtist,
             theMedium,  theNumTracks);

            // does the callnum not exist yet?
            if (!libraryItems.ContainsKey(theCallNumber))
            {
                // add to dict
                libraryItems.Add(theCallNumber, newMusic);

                _items.Add(new LibraryMusic(theTitle, thePublisher, theCopyrightYear,
                theLoanPeriod, theCallNumber, theDuration, theArtist,
                theMedium, theNumTracks));

                return SUCCESSFUL_ADD;
            }
            else
            {
                return FAILED_ADD;
            }

        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0 and
        //                theVolume >= 0 and theNumber >= 0
        // Postcondition: A library journal has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, number, discipline, and editor. The
        //                item is not checked out.
        //                The journal has been added to the Library.
        public bool AddLibraryJournal(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, int theVolume, int theNumber,
            String theDiscipline, String theEditor)
        {
            // create new journal object
            LibraryJournal newJournal = new LibraryJournal( theTitle,  thePublisher,  theCopyrightYear,
             theLoanPeriod,  theCallNumber,  theVolume,  theNumber,
             theDiscipline,  theEditor);

            // does the call num not exist yet?
            if (!libraryItems.ContainsKey(theCallNumber))
            {
                // add to dict
                libraryItems.Add(theCallNumber, newJournal);

                _items.Add(new LibraryJournal(theTitle, thePublisher, theCopyrightYear,
                theLoanPeriod, theCallNumber, theVolume, theNumber,
                theDiscipline, theEditor));

                return SUCCESSFUL_ADD;
            }
            else
            {
                return FAILED_ADD;
            }
        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0 and
        //                theVolume >= 0 and theNumber >= 0
        // Postcondition: A library magazine has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, and number. The item is not checked out.
        //                The magazine has been added to the Library.
        public bool AddLibraryMagazine(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, int theVolume, int theNumber)
        {
            LibraryMagazine newMag = new LibraryMagazine( theTitle,  thePublisher,  theCopyrightYear,
             theLoanPeriod,  theCallNumber,  theVolume,  theNumber);

            // does the callnum not exist yet?
            if (!libraryItems.ContainsKey(theCallNumber))
            {
                // add to dict
                libraryItems.Add(theCallNumber, newMag);

                _items.Add(new LibraryMagazine(theTitle, thePublisher, theCopyrightYear,
                        theLoanPeriod, theCallNumber, theVolume, theNumber));

                return SUCCESSFUL_ADD;
            }
            else
            {
                return FAILED_ADD;
            }
        }

        // Precondition:  None
        // Postcondition: The number of patrons in the library is returned
        public int GetPatronCount()
        {
            return libraryItems.Count;
        }

        // Precondition:  None
        // Postcondition: The number of items in the library is returned
        public int GetItemCount()
        {
            return libraryItems.Count;
        }

        // Precondition:  0 <= itemIndex < GetItemCount()
        //                0 <= patronIndex < GetPatronCount()
        // Postcondition: The specified item will be checked out by
        //                the specifed patron
        public bool CheckOut(string callNum, string patId )
        {
            LibraryItem BookToCheckOut = null;     // holder for book
            LibraryPatron PatronToCheckOut = null; // holder for patron

            // Are they valid paramenters
            if (libraryItems.ContainsKey(callNum) && libraryPatrons.ContainsKey(patId))
            {
                // Walk thru get the patron
                for (int i = 0; i < libraryPatrons.Count; i++)
                {
                    if (libraryPatrons.ElementAt(i).Key == patId)
                    {
                        PatronToCheckOut = libraryPatrons.ElementAt(i).Value;
                        break;
                    }
                }

                // walk thru get the item
                for (int i = 0; i < libraryItems.Count; i++)
                {
                    if (libraryItems.ElementAt(i).Key == callNum)
                    {
                        BookToCheckOut = libraryItems.ElementAt(i).Value; // set book to object
                        break;
                    }
                }

                // Is the book not checked out
                if (!BookToCheckOut.IsCheckedOut())
                {
                    BookToCheckOut.CheckOut(PatronToCheckOut);
                    transactions.Add(BookToCheckOut.CallNumber, DateTime.Now.AddDays(-21));
                    return SUCCESSFUL_ADD;
                }
                // the book is already checked out
                else
                {
                    return FAILED_ADD;
                }
            }
            // They're not valid Parameters
            else
            {
                return FAILED_ADD;
            }
        }

        // Precondition:  0 <= bookIndex < GetItemCount()
        // Postcondition: The specified book will be returned to shelf
        public decimal ReturnToShelf(string callNum)
        {
            DateTime transDate = DateTime.Now; // holder for checked out date
            int dayslate;                      // holder for # days late
            decimal latefee;                   // holder for late fee

            // walk thru to libraryItems
            for (int i = 0; i < libraryItems.Count; i++)
            {
                LibraryItem itemToReturn = libraryItems.ElementAt(i).Value; // set item to variable
                
                // find the item
                if (libraryItems.ElementAt(i).Key == callNum)
                {
                    // is the item checked out?
                    if (itemToReturn.IsCheckedOut())
                    {
                        // find the date of transaction
                        for (int t = 0; t < transactions.Count; t++)
                        {
                            if (transactions.ElementAt(t).Key == itemToReturn.CallNumber)
                                transDate = transactions.ElementAt(t).Value;
                        }

                        // calculate the late fee
                        dayslate = (transDate.AddDays(-itemToReturn.LoanPeriod) - DateTime.Now).Days;
                        if (dayslate <= 0)
                        {
                            // return it
                            itemToReturn.ReturnToShelf();
                            //book is not late
                            return 0;
                        }
                        else
                        {
                            //item is late, calc late fee
                            itemToReturn.ReturnToShelf();
                            return latefee = itemToReturn.CalcLateFee(dayslate);
                        }
                    }
                    else
                    {
                        //Item is not checked out
                        return -1;
                    }
                }
            }
            //item doesn't exist
            return -1;
        }

        // Precondition:  None
        // Postcondition: The number of items checked out from the library is returned
        public int GetCheckedOutCount()
        {
            int checkedOutCount = 0; // Running count of checked out books

            foreach (LibraryItem item in _items)
                if (item.IsCheckedOut())
                    ++checkedOutCount;

            return checkedOutCount;
        }

        // Namespace Helper Method - Use with care
        // Precondition:  None
        // Postcondition: The list of items stored in the library is returned
        internal List<LibraryItem> GetItemsList()
        {
            return libraryItems.Values.ToList();  
        }

        // Namespace Helper Method - Use with care
        // Precondition:  None
        // Postcondition: The list of patrons stored in the library is returned
        internal List<LibraryPatron> GetPatronsList()
        {
            return libraryPatrons.Values.ToList(); 
        }
        
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary in a formatted report
        public override string ToString()
        {
            // Using StringBuilder to show use of a more efficient way than String concatenation
            StringBuilder report = new StringBuilder(); // Will hold report as being built
            string NL = Environment.NewLine; // NewLine shortcut

            report.Append("Library Report\n");
            report.Append($"Number of items stored:      {GetItemCount(),4:d}{NL}");
            report.Append($"Number of items checked out: {GetCheckedOutCount(),4:d}{NL}");
            report.Append($"Number of patrons stored:    {GetPatronCount(),4:d}");

            return report.ToString();
        }

        internal IDictionary<string, DateTime> GetCheckedOutTransactions()
        {
            return transactions;
        }
    }
}
