// Program 3
// CIS 200-01
// Due: 4/5/2017
// By: D2214

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class EditBookForm : ItemFormBase
    {
        //Backing field for books
        private List<LibraryBook> _booklist;
        private string _author;

        // Precondition:  The EditBookForm is constructed with a valid book list
        // Postcondition: The list box is loaded with the book list
        public EditBookForm(List<LibraryBook> BookList)
        {
            InitializeComponent();

            _booklist = BookList;        // set book list to the backing field
            _author = authorTxtBox.Text; // set text box to the backing field

            // Populate list box
            foreach (LibraryBook i in _booklist)
            {
                bookListBox.Items.Add(i);
            }
        }

        internal int BookIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item combo box has been returned
            get
            {
                return bookListBox.SelectedIndex;
            }
        }

        internal string Author
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return authorTxtBox.Text;
            }

            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            set
            {
                // Since empty author is OK, just change null to empty string
                _author = (value == null ? string.Empty : value.Trim());
            }
        }

        // Precondition:  User clicks the ok button
        // Postcondition: The controls are validated and if true the dialog result is set to ok
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }

        // Precondition:  Validating event is called
        // Postcondition: Error is thrown if the selected index >=0
        private void bookListBox_Validating(object sender, CancelEventArgs e)
        {
            if (bookListBox.SelectedIndex >= 0)
                errorProvider1.SetError(bookListBox, "Invalid Selection");
        }

        // Precondition:  Validated event is called 
        // Postcondition: The errorprovider is clear
        private void bookListBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(bookListBox, "");
        }

        // Precondition:  EditBookForm is loaded
        // Postcondition: The form is loaded with all the controls disabled except cancel.
        private void EditBookForm_Load(object sender, EventArgs e)
        {

            this.itemTitleTxt.Enabled = false;       // Disable the control so user can't click
            this.itemPublisherTxt.Enabled = false;   // Disable the control so user can't click
            this.itemLoanPeriodTxt.Enabled = false;  // Disable the control so user can't click
            this.itemCopyrightTxt.Enabled = false;   // Disable the control so user can't click
            this.itemCallNumberTxt.Enabled = false;  // Disable the control so user can't click
            this.authorTxtBox.Enabled = false;       // Disable the control so user can't click
            this.okBtn.Enabled = false;              // Disable the control so user can't click
        }

        // Precondition:  User clicks the book list box 
        // Postcondition: The controls are unlocked if the user has selected a valid entry, if not error.
        //                If valid entry, the text boxes are filled with the corresponding values of the
        //                user selection.
        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populating the text boxes 
            if (bookListBox.SelectedItem == null)
                MessageBox.Show("Please select book");
            else
            {
                this.itemTitleTxt.Text = _booklist.ElementAt(bookListBox.SelectedIndex).Title;                        // set title
                this.itemPublisherTxt.Text = _booklist.ElementAt(bookListBox.SelectedIndex).Publisher;                // set publisher
                this.itemLoanPeriodTxt.Text = _booklist.ElementAt(bookListBox.SelectedIndex).LoanPeriod.ToString();   // set loan period
                this.itemCopyrightTxt.Text = _booklist.ElementAt(bookListBox.SelectedIndex).CopyrightYear.ToString(); // set copyright year
                this.itemCallNumberTxt.Text = _booklist.ElementAt(bookListBox.SelectedIndex).CallNumber;              // set call num
                this.authorTxtBox.Text = _booklist.ElementAt(bookListBox.SelectedIndex).Author;                       // set author


                this.itemTitleTxt.Enabled = true;       // Enabled 
                this.itemPublisherTxt.Enabled = true;   // Enabled
                this.itemLoanPeriodTxt.Enabled = true;  // Enabled
                this.itemCopyrightTxt.Enabled = true;   // Enabled
                this.itemCallNumberTxt.Enabled = true;  // Enabled
                this.authorTxtBox.Enabled = true;       // Enabled
                this.okBtn.Enabled = true;              // Enabled
            }
        }
    }
}
