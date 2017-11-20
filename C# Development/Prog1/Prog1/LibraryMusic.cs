//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This file contains the library media item, Music.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class LibraryMusic : LibraryMediaItem
    {
        private MediaType _medium;   // backing field for Medium
        private int _numberoftracks; // backing field for Number of tracks


        //Constructor
        // Precondition:  None
        // Postcondition: A library music item is instantiated and given a title, publisher, copyright, loan period,
        //                call number, duration, Artist, medium, and number of tracks. 
        public LibraryMusic(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod,
            string theCallNumber, double theDuration, string theArtist, MediaType theMedium, int theNumberofTracks )
                : base (theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Artist = theArtist;
            Medium = theMedium;
            NumberOfTracks = theNumberofTracks;
        }

        //Property for Artist
        //Auto-implemented
        public string Artist { get; set; }

        
        //Property for Medium
        public override MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The medium has been returned
            get { return _medium; }


            // Precondition:  None
            // Postcondition: The Medium is set to the specified value.
            set
            {
                {
                    if (value == MediaType.CD || value == MediaType.SACD || value == MediaType.VINYL)
                        _medium = value;
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                            $"{nameof(Medium)} is an invalid type");
                }
            }

        }

        //Property for NumTracks
        public int NumberOfTracks
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _numberoftracks;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 1)
                    _numberoftracks = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(NumberOfTracks)}", value,
                        $"{nameof(NumberOfTracks)} must be positive");
            }
        }


        //Precondition:  None
        //Postcondition: The calculated late fee is returned if it is less than $20.
        //                If it is $20 or more, it is set to $20 and returned.
        //
        public override decimal CalcLateFee(int dayslate)
        {
            decimal latefee = .55m;              // late fee
            decimal musiclatefee;                // holder for final result
            const decimal MAX_LATE_FEE = 20.0m;  // Constant variable for max late fee, 

            musiclatefee = latefee * dayslate;

            if (latefee > MAX_LATE_FEE)
                return MAX_LATE_FEE;
            else
                return latefee;
        }

        //Precondition: None
        //Postcondition: Returns a formatted string.
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return base.ToString() + $"Artist: {Artist}{NL}Type: {Medium}{NL}Number of Tracks: {NumberOfTracks}";
        }


    }
}
