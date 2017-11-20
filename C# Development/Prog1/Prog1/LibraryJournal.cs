//Program 1A
//Grading ID: D2214
//Due 2/15/2017
//CIS 200-01
//
//This file contains the library journal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class LibraryJournal : LibraryPeriodical
    {
        // Precondition:  theCopyrightYear >= 0
        // Postcondition: The library item has been initialized with the specified
        //                values for title, author, publisher, copyright year,
        //                call number, the volume, and the number. 
        public LibraryJournal(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, int theVolume, int theNumber, string theDiscipline, string theEditor)
            :base( theTitle,  thePublisher,  theCopyrightYear,  theLoanPeriod,  theCallNumber,  theVolume,  theNumber)
        {
            Editor = theEditor;
            Discipline = theDiscipline;
        }

        //Property discipline auto-implemented
        public string Discipline { get; set; }

        //Property Editor auto-implemented
        public string Editor { get; set; }


        //Precondition: None
        //Postcondition: The late fee is returned as a decimal. 
        //
        public override decimal CalcLateFee(int dayslate)
        {
            decimal latefee = .25m;
            decimal librarybooklatefee;

            librarybooklatefee = latefee * dayslate;

            return librarybooklatefee;
        }


        // Precondition:  None
        // Postcondition: A string is returned presenting the libary journal's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return base.ToString() + $"Discipline: {Discipline}{NL}Editor: {Editor}{NL}"; 
        }
    }
}
