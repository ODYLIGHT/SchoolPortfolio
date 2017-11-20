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
    public partial class PatronForm : Form
    {
        // Precondition:  None
        // Postcondition: The PatronForm GUI is initialized
        public PatronForm()
        {
            InitializeComponent();
        }

        internal string PatronName // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in patronNameInput is returned
            get { return patronNameInput.Text; }

            // Precondition:  None
            // Postcondition: Text in patronNameInput is set to specified value
            set { patronNameInput.Text = value; }
        }

        internal string PatronID // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in patronIDInput is returned
            get { return patronIDInput.Text; }

            // Precondition:  None
            // Postcondition: Text in patronIDInput is set to specified value
            set { patronIDInput.Text = value; }
        }


        // Precondition:  Attempting to change focus from patronIDInput
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void patronIDInput_Validating(object sender, CancelEventArgs e)
        {
            string patronID = patronIDInput.Text; // Value entered into patronIDInput

            // Will test patronID value to find if null or whitespace
            // If failure, error is provided
            // If success, nothing
            if (string.IsNullOrWhiteSpace(patronID))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderforID.SetError(patronIDInput, "Enter a valid ID!"); // Set error message

                patronIDInput.SelectAll(); // Select all text in inputTxt to ease correction
            }
        }

        // Precondition:  patronIDInput_Validating succeeded
        // Postcondition: Any error message set for inputTxt is cleared
        //                Focus is allowed to change
        private void patronIDInput_Validated(object sender, EventArgs e)
        {
            errorProviderforID.SetError(patronIDInput, ""); // Clears error message
        }

        private void patronNameInput_Validating(object sender, CancelEventArgs e)
        {
            string patronName = patronNameInput.Text; // Value entered into patronIDInput

            // Will test patronName value to find if null or whitespace
            // If failure, error is provided
            // If success, nothing
            if (string.IsNullOrWhiteSpace(patronName))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProviderforID.SetError(patronNameInput, "Enter a valid Name"); // Set error message

                patronNameInput.SelectAll(); // Select all text in inputTxt to ease correction
            }
        }

        // Precondition:  patronNameInput_Validating succeeded
        // Postcondition: Any error message set for inputTxt is cleared
        //                Focus is allowed to change
        private void patronNameInput_Validated(object sender, EventArgs e)
        {
            errorProviderforID.SetError(patronNameInput, ""); // Clears error message
        }

        // Precondition:  User has initiated click on submitBtn
        // Postcondition: If all controls on form validate, PatronForm is dismissed with OK result
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition:  User has initiated click down on cancel button
        // Postcondition: The dialogresult is set to cancel. From closes
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
