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
    public partial class PatronListForm : Form
    {
        public PatronListForm()
        {
            InitializeComponent();
        }

        internal string patronholder; //String for the patron output

        internal string Title // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in inputTxt is returned
            get { return patronTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { patronTextBox.Text = value; }
        }

        // Precondition: The patron list is instantiated
        // Postcondition: Nothing
        //
        private void PatronList_Load(object sender, EventArgs e)
        {

        }
    }
}
