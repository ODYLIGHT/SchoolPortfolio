//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This file contains the library media item which is an abstract class derived from LibraryItem.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    public abstract class LibraryMediaItem : LibraryItem 
    {

        private double _duration;  //Backing field for duration


        // Precondition:  theCopyrightYear >= 0 and duration is >=0
        // Postcondition: The library item has been initialized with the specified
        //                values for title, author, publisher, copyright year, and
        //                call number. 
        public LibraryMediaItem(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, double theDuration)
            : base( theTitle,  thePublisher,  theCopyrightYear,  theLoanPeriod, theCallNumber)
        {
            _duration = theDuration;
        }

        //Property for Duration
        public double Duration
        {
            // Precondition: None
            // Postcondition: Duration is returned
            get { return _duration; }

            // Precondition:  Duration >= 0
            // Postcondition: Duration is set to the specified 
            set
            {
                if (value >= 0)
                    _duration = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Duration)}", value,
                        $"{nameof(Duration)} must be >= 0");
            }
        }

        //Abstract Property for Medium
        public abstract MediaType Medium
        {
            // Precondition:  None
            // Postcondition: None
            get; set; 
        }

        public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL};  //Enum type created for media types



        //Precondition: ToString is called.
        //Postcondition: Returns a formatted string.
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return base.ToString() + $"{NL}Duration: {Duration}{NL}" ; 
        }

    }
}
