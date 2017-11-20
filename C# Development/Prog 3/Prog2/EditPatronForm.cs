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
    public partial class EditPatronForm : PatronForm
    {
        private List<LibraryPatron> _patrons; // List of library patrons

        // Precondition:  The EditPatronForm is constructed with a valid patron list
        // Postcondition: The list box is populated 
        public EditPatronForm(List<LibraryPatron> patronList)
        {
            InitializeComponent();

            _patrons = patronList; //Pass patron list

            //Load the list box
            foreach(LibraryPatron i in _patrons)
            {
                editPatronListBox.Items.Add(i);
            }
        }

        internal int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item combo box has been returned
            get
            {
                return editPatronListBox.SelectedIndex;
            }
        }

        // Precondition:  User clicks the OK button
        // Postcondition: The controls are validated and if valid, the dialog
        //                result is set to OK
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }

        // Precondition:  User clicks the OK button
        // Postcondition: The controls are validated and if valid, the dialog
        private void editPatronListBox_Validating(object sender, CancelEventArgs e)
        {
            if (editPatronListBox.SelectedIndex >= 0)
                errorProvider1.SetError(patronNameTxt, "Invalid Selection");
        }

        private void editPatronListBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronNameTxt, "");
        }

        // Precondition:  User clicks the list box 
        // Postcondition: The controls are unlocked if the user
        //                selects an item, if not error
        private void editPatronListBox_Click(object sender, EventArgs e)
        {
            if (editPatronListBox.SelectedItem == null)
                MessageBox.Show("Select Valid Item");
            else
            {
                this.patronIdTxt.Text = _patrons.ElementAt(editPatronListBox.SelectedIndex).PatronID;
                this.patronNameTxt.Text = _patrons.ElementAt(editPatronListBox.SelectedIndex).PatronName;
                this.patronNameTxt.Enabled = true; // Enable the control so user can click
                this.patronIdTxt.Enabled = true;   // Enable the control so user can click
                this.okBtn.Enabled = true;         // Enable the control so user can click
            }
        }

        // Precondition:  Edit Patron Form is loaded
        // Postcondition: The patron name and id text boxes are disabled,
        //                as well as the ok button
        private void EditPatronForm_Load(object sender, EventArgs e)
        {
            this.patronNameTxt.Enabled = false; // Disable the control so user can't click
            this.patronIdTxt.Enabled = false;   // Disable the control so user can't click
            this.okBtn.Enabled = false;         // Disable the control so user can't click
        }
    }
}
