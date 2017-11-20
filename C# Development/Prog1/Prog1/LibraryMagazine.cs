//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This file contains the library magazine

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class LibraryMagazine : LibraryPeriodical
    {



        // Precondition:  theCopyrightYear >= 0, 
        // Postcondition: The library item has been initialized with the specified
        //                values for title, author, publisher, copyright year,
        //                call number, the volume, and the number. 
        public LibraryMagazine(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, int theVolume, int theNumber)
            :base( theTitle,  thePublisher,  theCopyrightYear,  theLoanPeriod,  theCallNumber,  theVolume,  theNumber)
        {         
        }

        //CalcLateFee Method
        public override decimal CalcLateFee(int dayslate)
        {
            decimal feeperday = 0.25m;          // Late fee per day
            decimal latefee;                    // Final late fee
            const decimal MAX_LATE_FEE = 20.0m; // Max late fee

            latefee = feeperday * dayslate;

            if (latefee > MAX_LATE_FEE)
                return MAX_LATE_FEE;
            else
                return latefee;
        }


        // Precondition:  None
        // Postcondition: A string is returned presenting the libary periodical's data on
        //                separate lines
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
