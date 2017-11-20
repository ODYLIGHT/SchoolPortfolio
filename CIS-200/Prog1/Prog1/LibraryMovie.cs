//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This file contains the library media item, Movie.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class LibraryMovie : LibraryMediaItem
    {       
        private MediaType _medium;   //Backing Field for medium

        //Constructor
        // Precondition:  None
        // Postcondition: A library movie is instantiated and given a library itme attributes in addition to 
        //                a director, medium, and rating.
        public LibraryMovie(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, 
            string theCallNumber, double theDuration, string theDirector, MediaType theMedium, MPAARatings theRating)
                : base (theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Director = theDirector;
            Rating = theRating;
        }

        //Enum type MPAARAtings
        public enum MPAARatings { G, PG, PG13, R, NC17, U};  

        //Auto Implemented 
        public string Director {get; set;}

        public override MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The medium has been returned
            get { return _medium; }

            // Precondition:  None
            // Postcondition: The medium is set to the specified value.
            set
            {
                if (value == MediaType.DVD || value == MediaType.VHS || value == MediaType.BLURAY)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                        $"{nameof(Medium)} is an invalid type");
            }
        }

        //Auto implemented
        public MPAARatings Rating {get; set;} 



        //Precondition: None
        //Postcondition: The late fee is returned as a decimal. 
        //
        public override decimal CalcLateFee(int dayslate)
        {
            decimal bluraylatefee = 1.5m; // Late fee for blu rays
            decimal vhslatefee = 1.0m;    // Late fee for vhs
            decimal dvdlatefee = 1.0m;    // Late fee for  DVDs
            decimal libraryitem;          // Final calculation for library item
            decimal latefee;              // Which Late fee to apply

            if (this.Medium == MediaType.BLURAY)     //If its bluray 
                latefee = bluraylatefee;
            else if (this.Medium == MediaType.VHS)   //If its vhs
                latefee = vhslatefee;
            else
                latefee = dvdlatefee;                //Then its a dvd

            libraryitem = latefee * dayslate;        //Calc the late fee

            return libraryitem;
        }


        //Precondition: None
        //Postcondition: Returns a formatted string.
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return $"Director: {Director}{NL}Media Type: {Medium}{NL}Rating: {Rating}{NL}" + base.ToString();
        }
    }
}
