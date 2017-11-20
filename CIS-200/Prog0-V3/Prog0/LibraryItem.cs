using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog4
{
    public abstract class LibraryItem
    {
        //Backing Fields 
        private string _title;       //Backing field for Title
        private string _publisher;   //Backing field for Publisher
        private int _copyrightyear;  //Backing field for CopyrightYear
        private int _loanperiod;     //Backing field for LoanPeriod
        private string _callnumber;  //Backing field for CallNumber


        //Pre condition:
        //Post condition: 
        public LibraryItem(string title, string publisher, int copyrightyear, int loanperiod, string callnumber)
        {
            Title = title;
            Publisher = publisher;
            CopyrightYear = copyrightyear;
            LoanPeriod = loanperiod;
            CallNumber = callnumber;
            
        }

        //Title Property
        public string Title 
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                        $"{nameof(Title)} must not be null or empty");
                else
                    _title = value.Trim(); 

            }
        }

        //Publisher Property
        public string Publisher { get; set; }

        //CopyrightYear Property
        public int CopyrightYear
        {
            get { return _copyrightyear; }
            set
            {
                if (value >= 0)
                    _copyrightyear = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                        $"{nameof(CopyrightYear)} must not be negative.");
            }

        }

        //LoanPeriod Property
        public int LoanPeriod
        {
            get { return _loanperiod; }
            set
            {
                if (value >= 0)
                    _loanperiod = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                        $"{nameof(LoanPeriod)} must not be negative.");
            }
        }

        //CallNumber Property
        public string CallNumber
        {
            get { return _callnumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                        $"{nameof(CallNumber)} must not be null or empty");
                else
                    _callnumber = value.Trim();

            }
        }
        
        //Read-only Property for LibraryPatron
        public LibraryPatron LibraryPatron
        {
            get;
        }


        //Abstract method for Calculating Late Fee
        public abstract decimal CalcLateFee(int dayslate); 

        //Method ToString
        public override string ToString()
        {
            string final;

            final = $"{Title}/n{Publisher}/n{CopyrightYear}/n{LoanPeriod}/n{CallNumber}/n{CallNumber}";

            return final;
        }
    }
}
