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
using LibraryItems;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryItems
{
    public partial class CheckOut : Form
    {
        // Constructor that accepts the list of items and the list of the patron
        public CheckOut(List<LibraryItem> notcheckedoutitems, List<LibraryPatron> patrons)
        {
            InitializeComponent();

            // Loop to add library items to the itemcombo box that are checked out.
            foreach (LibraryItem i in notcheckedoutitems)
            {
                itemComboBox.Items.Add(i.Title + " , " + i.CallNumber);
            }

            // Loop to add library patrons to the patron combo box.
            foreach (LibraryPatron i  in patrons)
            {
                patronComboBox.Items.Add(i.PatronName + " " + i.PatronID);
            }
        }

        internal int ItemSelected // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in itemComboBox is returned
            get { return itemComboBox.SelectedIndex; }

            // Precondition:  None
            // Postcondition: None
            set { }
        }

        internal int PatronSelected // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in patronComboBox is returned
            get { return patronComboBox.SelectedIndex; }

            // Precondition:  None
            // Postcondition: None
            set { }
        }


        // Precondition:  Ok button is clicked
        // Postcondition: The dialog box validates the controls and 
        //                sets the dialog box to OK
        private void okBtn_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition:  Attempting to change focus from the itemComboBox
        // Postcondition: If no item is selected then an error is thrown,
        //                else the focus can change.
        private void itemSelected_Validating(object sender, CancelEventArgs e)
        {
            int item = itemComboBox.SelectedIndex; // Value selected in itemComboBox

            // Will test selected item index value to find if null
            // If failure, error is provided
            // If success, nothing
            if (item < 0 || item > itemComboBox.Items.Count)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderCheckOutForm.SetError(itemComboBox, "Pick a valid item!"); // Set error message               
            }
        }

        // Precondition:  itemSelected_Validating succeeded
        // Postcondition: Any error message set for itemComboBox is cleared
        //                Focus is allowed to change
        private void itemSelected_Validated(object sender, EventArgs e)
        {
            errorProviderCheckOutForm.SetError(itemComboBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from the patronComboBox
        // Postcondition: If no patron is selected then an error is thrown,
        //                else the focus can change.
        private void patronSelected_Validating(object sender, CancelEventArgs e)
        {
            int patron = patronComboBox.SelectedIndex; // Value selected in patronComboBox

            // Will test selected patron index to find if null
            // If failure, error is provided
            // If success, nothing
            if (patron < 0 || patron > patronComboBox.Items.Count)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderCheckOutForm.SetError(patronComboBox, "Pick a valid patron!"); // Set error message               
            }
        }

        // Precondition:  patronSelected_Validating succeeded
        // Postcondition: Any error message set for patronComboBox is cleared
        //                Focus is allowed to change
        private void patronSelected_Validated(object sender, EventArgs e)
        {
            errorProviderCheckOutForm.SetError(patronComboBox, ""); // Clears error message
        }

        // Precondition:  Cancel button is clicked
        // Postcondition: The dialog box is canceled 
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
