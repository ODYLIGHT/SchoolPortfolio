// Program 0
// CIS 200-01
// By: Andrew L. Wright (Student's use Grading ID)
// Due: 1/20/2017

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

// Version 3
// Added validation in set accessors of properties, trims strings
// Used string.IsNullOrWhitespace to test

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public const int DEFAULT_YEAR = 2016; // Default copyright year

    private string _title;      // The book's title
    private string _author;     // The book's author
    private string _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private string _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status

    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(string theTitle, string theAuthor, string thePublisher,
        int theCopyrightYear, string theCallNumber)
    {
        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;

        ReturnToShelf(); // Make sure book is not checked out
    }

    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  value must not be null or empty
        // Postcondition: The title has been set to the specified value
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                _title = value.Trim();
            else
                throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                    $"{nameof(Title)} must not be null or empty");
        }
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

    public string Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return _publisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            // Since empty author is OK, just change null to empty string
            _publisher = (value == null ? string.Empty : value.Trim());
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return _copyrightYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
                _copyrightYear = value;
            else
                throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                    $"{nameof(CopyrightYear)} must be >= 0");
        }
    }

    public string CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return _callNumber;
        }

        // Precondition:  value must not be null or empty
        // Postcondition: The call number has been set to the specified value
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                _callNumber = value.Trim();
            else
                throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                    $"{nameof(CallNumber)} must not be null or empty");
        }
    }

    // Create HAS-A
    public LibraryPatron Patron
    {
        // Precondition:  None
        // Postcondition: The book's patron has been returned
        get; // Auto-implement is fine

        // Helper
        // Precondition:  None
        // Postcondition: The book's patron has been set to the specified value
        private set; // Auto-implement is fine 
    }

    // Precondition:  thePatron != null
    // Postcondition: The book is checked out
    public void CheckOut(LibraryPatron thePatron)
    {
        _checkedOut = true;
        if (thePatron != null)
            Patron = thePatron;
        else
            throw new ArgumentNullException($"{nameof(thePatron)}", $"{nameof(thePatron)} must not be null");
    }

    // Precondition:  None
    // Postcondition: The book is not checked out
    public void ReturnToShelf()
    {
        _checkedOut = false;
        Patron = null; // Remove previously stored reference to patron
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
    }

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
}
