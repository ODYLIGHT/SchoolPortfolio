// Program 2
// CIS 200-01
// Due: 3/9/2017
// By: D2214

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class BookForm : Form
    {
        // Precondition:  None
        // Postcondition: The BookForm GUI is initialized
        public BookForm()
        {
            InitializeComponent();
        }

        internal string Title // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in inputTxt is returned
            get { return titleTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { titleTextBox.Text = value; }
        }

        internal string Publisher // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in publisher is returned
            get { return publisherTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in publisher is set to specified value
            set { publisherTextBox.Text = value; }
        }

        internal string CopyrightYear // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in copyright year is returned
            get { return copyrightyearTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in copy right year is set to specified value
            set { copyrightyearTextBox.Text = value; }
        }

        internal string LoanPeriod // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in loanperiod is returned
            get { return loanPeriodTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in loan period is set to specified value
            set { loanPeriodTextBox.Text = value; }
        }

        internal string CallNumber // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in loanperiod is returned
            get { return callNumberTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in loan period is set to specified value
            set { callNumberTextBox.Text = value; }
        }

        internal string Author // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in author is returned
            get { return authorTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in author is set to specified value
            set { authorTextBox.Text = value; }
        }


        // Precondition:  Attempting to change focus from Title
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void title_Validating(object sender, CancelEventArgs e)
        {
            string title = titleTextBox.Text; // Value entered into patronIDInput

            // Will test title value to find if null or whitespace
            // If failure, error is provided
            // If success, nothing
            if (string.IsNullOrWhiteSpace(title))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderBookForm.SetError(titleTextBox, "Enter a valid Title!"); // Set error message

                titleTextBox.SelectAll(); // Select all text in titleTextBox to ease correction
            }
        }

        // Precondition:  title_Validating succeeded
        // Postcondition: Any error message set for titleTextBox is cleared
        //                Focus is allowed to change
        private void title_Validated(object sender, EventArgs e)
        {
            errorProviderBookForm.SetError(titleTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from Publisher
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void publisher_Validating(object sender, CancelEventArgs e)
        {
            string publisher = publisherTextBox.Text; // Value entered into publishertext box

            // Will test publisher value to find if null or whitespace
            // If failure, error is provided
            // If success, nothing
            if (string.IsNullOrWhiteSpace(publisher))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderBookForm.SetError(publisherTextBox, "Enter a valid Publisher!"); // Set error message

                publisherTextBox.SelectAll(); // Select all text in publisher text box to ease correction
            }
        }

        // Precondition:  publisher_Validating succeeded
        // Postcondition: Any error message set for publisherTextBox is cleared
        //                Focus is allowed to change
        private void publisher_Validated(object sender, EventArgs e)
        {
            errorProviderBookForm.SetError(publisherTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from copy right year.
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void copyrightyear_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            
            // Will test the copyright year value is an integer and 0 or greater
            // If failure, error is provided
            // If success, nothing
            if (!ValidCopyrightyear(copyrightyearTextBox.Text,out errorMsg))
            {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProviderBookForm.SetError(copyrightyearTextBox, errorMsg); // Set error message

                    copyrightyearTextBox.SelectAll(); // Select all text in the copyrightyeartextbox to ease correction  
            }
        }

        // Precondition:  copyright year has been through copyrightyear_validating
        // Postcondition: the copyright year value is at least 1 or greater. 
        //                try parse it twice (can't even trust myself)
        //                
        public bool ValidCopyrightyear(string copyrightyearTextBox, out string errorMsg)
        {
            const int ZERO = 0; //variable to compare against
            int copyrightyear;  // variable to hold copyrightyear

            if (!int.TryParse(copyrightyearTextBox, out copyrightyear))
            {
                errorMsg = "Enter a valid Copy Right Year";
                return false;
            }
            else if (int.Parse(copyrightyearTextBox) < ZERO)
            {
                errorMsg = "Copyright year must be postiive.";
                return false;
            }
            else
            {
                errorMsg = "";
                return true;
            }          
        }

        // Precondition:  copyrightyear_Validating succeeded
        // Postcondition: Any error message set for copyrightyearTextBox is cleared
        //                Focus is allowed to change
        private void copyrightyear_Validated(object sender, EventArgs e)
        {
            errorProviderBookForm.SetError(copyrightyearTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from loan period
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void loanperiod_Validating(object sender, CancelEventArgs e)
        {
            string loanperioderrorMsg;

            // Will test loan period value to find if integer, and greater than 0
            // If failure, error is provided
            // If success, nothing
            if (!ValidLoanPeriod(copyrightyearTextBox.Text, out loanperioderrorMsg))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderBookForm.SetError(loanPeriodTextBox, loanperioderrorMsg); // Set error message

                loanPeriodTextBox.SelectAll(); // Select all text in loan period text box to ease correction
            }
        }

        // Precondition:  Loan period has been through loanperiod_validating
        // Postcondition: the loan period value is at least 1 or greater. try parse it twice (can't even trust myself)
        //                
        public bool ValidLoanPeriod(string loanperiodTextBox, out string loanperioderrorMsg)
        {
            const int ONE = 1;  //Constant Zero variable
            int loanperiod;      //Variable to hold loan period

            if (!int.TryParse(loanPeriodTextBox.Text, out loanperiod))
            {
                loanperioderrorMsg = "Enter a valid loan period.";
                return false;
            }
            else if (loanperiod < ONE)
            {
                loanperioderrorMsg = "Loan period must be positive.";
                return false;
            }
            else
            {
                loanperioderrorMsg = "";
                return true;
            }
        }

        // Precondition:  loanperiod_Validating succeeded
        // Postcondition: Any error message set for loanPeriodTextBox is cleared
        //                Focus is allowed to change
        private void loanperiod_Validated(object sender, EventArgs e)
        {
            errorProviderBookForm.SetError(loanPeriodTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from Call number
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void callnumber_Validating(object sender, CancelEventArgs e)
        {
            string callnumber = callNumberTextBox.Text; // Value entered into patronIDInput

            // Will test call number value to find if null or whitespace
            // If failure, error is provided
            // If success, nothing
            if (string.IsNullOrWhiteSpace(callnumber))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderBookForm.SetError(callNumberTextBox, "Enter a valid Call Number!"); // Set error message

                callNumberTextBox.SelectAll(); // Select all text in call number text box to ease correction
            }
        }

        // Precondition:  callnumber_Validating succeeded
        // Postcondition: Any error message set for callNumberTextBox is cleared
        //                Focus is allowed to change
        private void callnumber_Validated(object sender, EventArgs e)
        {
            errorProviderBookForm.SetError(callNumberTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from Author
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void author_Validating(object sender, CancelEventArgs e)
        {
            string author = authorTextBox.Text; // Value entered into patronIDInput

            // Will test title value to find if null or whitespace
            // If failure, error is provided
            // If success, nothing
            if (string.IsNullOrWhiteSpace(author))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderBookForm.SetError(authorTextBox, "Enter a valid Author!"); // Set error message

                authorTextBox.SelectAll(); // Select all text in authorTextBox to ease correction
            }
        }

        // Precondition:  author_Validating succeeded
        // Postcondition: Any error message set for authorTextBox is cleared
        //                Focus is allowed to change
        private void author_Validated(object sender, EventArgs e)
        {
            errorProviderBookForm.SetError(authorTextBox, ""); // Clears error message
        }

        // Precondition:  Add button is clicked
        // Postcondition: The Dialog result is returned as OK
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }             
        }

        // Precondition:  Exit button is clicked.
        // Postcondition: Book form is closed
        //               
        private void exitBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
