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


public class LibraryPatron
{
    private string _patronName; // Name of the patron
    private string _patronID;   // ID of the patron

    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(string name, string id)
    {
        PatronName = name;
        PatronID = id;
    }

    public string PatronName
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return _patronName;
        }

        // Precondition:  The value to be set isn't null or empty.
        // Postcondition: The patron's name has been set to the specified value or if null or empty, throw exception.
        set
        {
            value = value.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                _patronName = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Patron name is null or empty.");
            }
        }
    }

    public string PatronID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return _patronID;
        }

        // Precondition:  The value to be set isn't null or empty.
        // Postcondition: The patron's ID has been set to the specified value or if null or empty, throw exception.
        set
        {
            value = value.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                _patronID = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Patron ID is null or empty.");
            }
        }
    }
    
    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on
    //                separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Name: {PatronName}{NL}ID: {PatronID}";
    }
    

}

