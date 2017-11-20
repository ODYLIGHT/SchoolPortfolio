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
    public partial class Return : Form
    {
        // Precondition:  Call to create a return form, and a valid list is passed.
        // Postcondition: The form is created and the itemComboBox is populated.
        //                
        public Return(List<LibraryItem> checkedoutitems)
        {
            InitializeComponent();

            // Add each checked out item to the combo box
            foreach (LibraryItem i in checkedoutitems)
            {
                itemComboBox.Items.Add(i.Title + " , " + i.CallNumber);
            }
        }

        internal int ItemSelected // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in inputTxt is returned
            get { return itemComboBox.SelectedIndex; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { }
        }

        // Precondition: The okay button is clicked.
        // Postcondition: The form is validated and 
        //                dialogresult is returned as OK
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition:  Attempting to change focus from the combo box.
        // Postcondition: If entered value is valid selection, focus will change,
        //                else focus will remain and error provider message set
        private void itemComboBox_Validating(object sender, CancelEventArgs e)
        {
            string title = itemComboBox.Text; // Value entered into itemComboBox

            // Will test title value to find if null or whitespace
            // If failure, error is provided
            // If success, nothing
            if (string.IsNullOrWhiteSpace(title))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                itemComboBoxErrorProvider.SetError(itemComboBox, "Select a valid item!"); // Set error message
            }
        }

        // Precondition:  itemComboBox_Validating succeeded
        // Postcondition: Any error message set for itemComboBox is cleared
        //                Focus is allowed to change
        private void itemComboBox_Validated(object sender, EventArgs e)
        {
            itemComboBoxErrorProvider.SetError(itemComboBox, ""); // Clears error message
        }

        // Precondition: The cancel button is clicked
        // Postcondition: The dialogresult is set to cancel, form closes.
        //      
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }        

    }
}
