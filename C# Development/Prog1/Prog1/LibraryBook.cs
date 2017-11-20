//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This file contains the library book

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class LibraryBook : LibraryItem
    {
        public const int DEFAULT_YEAR = 2016; // Default copyright year

        private string _author;               // The book's author

        // Precondition:  theCopyrightYear >= 0
        // Postcondition: The library book has been initialized with the specified
        //                values for title, author, publisher, copyright year, and
        //                call number. The book is not checked out.
        public LibraryBook(string theTitle, string theAuthor, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber)
            : base( theTitle,  thePublisher,  theCopyrightYear,  theLoanPeriod,  theCallNumber)
        {
            Author = theAuthor;

            ReturnToShelf(); // Make sure book is not checked out
        }

        public string Author
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return _author;
            }

            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            set
            {
                // Since empty author is OK, just change null to empty string
                _author = (value == null ? string.Empty : value.Trim());
            }
        }

        // Precondition:  None
        // Postcondition: true is returned if the book is checked out,
        //                otherwise false is returned


        // Precondition:  None
        // Postcondition: A string is returned presenting the libary book's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            string checkedOutBy; // Holds checked out message

            if (IsCheckedOut())
                checkedOutBy = $"Checked Out By: {NL}{Patron}";
            else
                checkedOutBy = "Not Checked Out";

            return $"Title: {Title}{NL}Author: {Author}{NL}Publisher: {Publisher}{NL}" +
                $"Copyright: {CopyrightYear:D4}{NL}{checkedOutBy}";
        }

        //Precondition: None
        //Postcondition: The late fee is returned as decimal 
        //
        public override decimal CalcLateFee(int dayslate)
        {
            decimal latefee = .25m;      // The late fee
            decimal librarybooklatefee;  // Holder for the final result

            librarybooklatefee = latefee * dayslate;

            return librarybooklatefee;
     
        }

    }
}
