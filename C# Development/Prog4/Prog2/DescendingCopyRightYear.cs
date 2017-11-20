// Program 4
// CIS 200-01
// Due: 4/17/2017
// By: D2214

// This class sorts library items in descending order by their copyright year.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class DescendingCopyRightYear : Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: Reverses natural title order, so descending
        //                When t1 < t2, method returns positive #
        //                When t1 == t2, method returns zero
        //                When t1 > t2, method returns negative #
        public override int Compare(LibraryItem x, LibraryItem y)
        {
            if (x.CopyrightYear == y.CopyrightYear)
                return 0;
            else if (x.CopyrightYear > y.CopyrightYear)
                return -1;
            else if (x.CopyrightYear < y.CopyrightYear)
                return 1; 

            return (-1) * x.CompareTo(y); // Descending Order
        }
    }
}
