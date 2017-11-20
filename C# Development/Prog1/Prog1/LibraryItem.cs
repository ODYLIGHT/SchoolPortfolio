//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This file contains the library Item which is the abstract class for all library items.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    public abstract class LibraryItem
    {
        //Backing Fields 
        private string _title;       //Backing field for Title
        private string _publisher;   //Backing field for Publisher
        private int _copyrightyear;  //Backing field for CopyrightYear
        private int _loanperiod;     //Backing field for LoanPeriod
        private string _callnumber;  //Backing field for CallNumber
        private bool _checkedOut;    // The book's checked out status



        // Precondition:  theCopyrightYear >= 0
        // Postcondition: The library item has been initialized with the specified
        //                values for title, author, publisher, copyright year, and
        //                call number. 
        public LibraryItem(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber)
        {
            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            LoanPeriod = theLoanPeriod;
            CallNumber = theCallNumber;
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
                return _copyrightyear;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightyear = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                        $"{nameof(CopyrightYear)} must be >= 0");
            }
        }

        public int LoanPeriod
        {
            // Precondition:  None
            // Postcondition: The loan period will be returned
            get
            {
                return _loanperiod;
            }

            // Precondition:  value >= 0
            // Postcondition: The loan period will be set to the value
            set
            {
                if (value >= 0)
                    _loanperiod = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                        $"{nameof(LoanPeriod)} must be >= 0");
            }
        }

        public string CallNumber
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _callnumber;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The call number has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _callnumber = value.Trim();
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

        //Read-only Property for LibraryPatron
        public LibraryItem LibraryPatron
        {
            get;
        }

        // Precondition:  None
        // Postcondition: The book is not checked out
        public void ReturnToShelf()
        {
            _checkedOut = false;   
            Patron = null;         // Remove previously stored reference to patron
        }

        // Precondition:  None
        // Postcondition: true is returned if the book is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut()
        {
            return _checkedOut;
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
        // Postcondition: Calculation is returned 
        public abstract decimal CalcLateFee(int dayslate);

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary book's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine;  // New line variable

            return $"Title: {Title}{NL}Publisher: {Publisher}{NL}Copyright Year: {CopyrightYear}{NL}Loan Period: {LoanPeriod} days{NL}Call Number: {CallNumber}{NL}Checked Out: {IsCheckedOut()}";
        }
    }
}
