//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This file contains the library periodical which is a library item.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    public abstract class LibraryPeriodical : LibraryItem
    {
        private int _number; //backing field for number
        private int _volume; //backing field for volume


        // Precondition:  theCopyrightYear >= 0 and volume is >= 1
        // Postcondition: The library item has been initialized with the specified
        //                values for title, author, publisher, copyright year,
        //                call number, the volume, and the number. 
        public LibraryPeriodical(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallnumber, int theVolume, int theNumber)
            : base(theTitle,  thePublisher,  theCopyrightYear,  theLoanPeriod, theCallnumber)
        {
            Number = theNumber;
            Volume = theVolume;
        }

        //Property for Volume
        public int Volume
        {

            // Precondition:  None
            // Postcondition: The volume will be returned
            get { return _volume; }

            // Precondition:  value >= 1
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 1)
                    _volume = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Volume)}", value,
                        $"{nameof(Volume)} must be positive");
            }
        }

        //Property for Number
        public int Number
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get { return _number; }

            // Precondition:  The value must be equal to or greatr than 1
            // Postcondition: The number is set to the specified value.
            set
            {
                if (value >= 1)
                    _number = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Number)}", value,
                        $"{nameof(Number)} must be positive");
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary periodical's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            return base.ToString() + $"{NL}Volume: {Volume}{NL}Number:{Number}{NL}";
        }
    }
}
