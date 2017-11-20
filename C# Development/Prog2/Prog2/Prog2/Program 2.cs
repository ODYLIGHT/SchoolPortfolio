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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // New Library is instantiated.s
        internal Library newLibrary = new Library();

        // Precondition:  User clicks on Patron Form 
        // Postcondition: Modal box displays.  User submits patron name,
        //                and patron ID.  User can submit, or exit the form.
        //                the user input is validated before changing control focus.
        public void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronform = new PatronForm(); // Patron form creation
            DialogResult result;                      // Dialog result is created

            result = patronform.ShowDialog();  // Displays the modal patronform

            if (result == DialogResult.OK)
            {
                string patronID = patronform.PatronID;       // PatronID from user
                string patronName = patronform.PatronName;   // PatronName from user
                newLibrary.AddPatron(patronName, patronID);  // Patron is added to the library.
            }
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookform = new BookForm();  // Bookform is created
            DialogResult result;                 // Dialog result is created

            result = bookform.ShowDialog();

            if(result == DialogResult.OK)
            {
                string title = bookform.Title;                         // Title is set using the form property
                string publisher = bookform.Publisher;                 // Publisher is set using the form property
                int copyrightyear = int.Parse(bookform.CopyrightYear); // Copyrightyear is set using the form property
                int loanperiod = int.Parse(bookform.LoanPeriod);       // Loanperiod is set using the form property
                string callnumber = bookform.CallNumber;               // Callnumber is set using the form property
                string author = bookform.Author;                       // Author is set using the form property

                // A new library book is added to the library
                newLibrary.AddLibraryBook(title, publisher, copyrightyear, loanperiod, callnumber, author); 
            }
        }

        // Precondition:  None
        // Postcondition: The form is closed.
        //                
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Precondition:  None
        // Postcondition: Message box shows program details.
        //                
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // New line variable
            const string ABOUT = "About";    // Constant string for the message box title.

            MessageBox.Show($"Program 2{NL}CIS 200 - 01 {NL}Due: 3 / 9 / 2017 {NL}By: D2214",ABOUT);//Print the about message
        }


        // Precondition:  The patron list menu button is clicked.
        // Postcondition: Patron list is displayed in form
        //                
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronListForm patronlist = new PatronListForm();  // New patron list form

            // Text string added to patron holder describing the number of patrons
            patronlist.patronholder = AppendLine("Number of Patrons: " + newLibrary.GetPatronCount().ToString());

            //Walking through each library patron and adding each item's tostring to the string patron holder
            foreach (LibraryPatron i in newLibrary._patrons)
            {
                patronlist.patronholder += AppendLine(i.ToString());
            }

            patronlist.Title = patronlist.patronholder; // Setting the patron list form property Title to the string patron holder

            patronlist.ShowDialog(); // Show the new patron list form   
        }


        // Precondition:  The item list menu button is clicked.
        // Postcondition: Item list is displayed in form
        //          
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemListForm itemlistform = new ItemListForm();  // New patron list form

            itemlistform.stringholder = AppendLine("Number of Items: " + newLibrary.GetItemCount().ToString());

            //Walking through each library item and adding the patron's tostring to a stringholder
            foreach (LibraryItem i in newLibrary._items)
            {
                itemlistform.stringholder += AppendLine(i.ToString());
            }

            itemlistform.Title = itemlistform.stringholder; // Setting the patron list form property Title to the string patron holder

            itemlistform.ShowDialog(); // Show the item list form 
        }


        // Precondition:  The checked out item list menu button is clicked.
        // Postcondition: Checked out item list is displayed in form
        //          
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckedOutItemsForm checkedoutform = new CheckedOutItemsForm(); // Checked out form is created

            //Checked out count is shown and spaced
            checkedoutform.checkedOutTextBox.Text = AppendLine("Number of Checked Out Items: " + newLibrary.GetCheckedOutCount().ToString());

            //Walking through the array to print out each item in the list that is checkedout
            foreach (LibraryItem i in newLibrary.GetItemsList())
            {     
                if (i.IsCheckedOut())
                    checkedoutform.checkedOutTextBox.Text += AppendLine((i.ToString()));
            }
            checkedoutform.ShowDialog(); // Checked out form is displayed
        }


        // Precondition:  The checked out item list menu button is clicked.
        // Postcondition: Checked out item list is displayed in form
        //         
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> notcheckedoutitems = new List<LibraryItem>(); //creating an array of items not checked out
            DialogResult result;                                            //the result of the dialog box

            // Each library item is added to the array of items not checked out
            foreach (LibraryItem i in newLibrary._items)
            {
                if (!i.IsCheckedOut())
                {
                    notcheckedoutitems.Add(i);
                }
            }

            //creating the checkout form (dialog)
            CheckOut checkout = new CheckOut(notcheckedoutitems, newLibrary.GetPatronsList());

            // Checkout form is shown
            result = checkout.ShowDialog();

            if (result == DialogResult.OK)
            {
                //This is the actual item selected by the user to return
                var selecteditem = notcheckedoutitems.ElementAt(checkout.ItemSelected);

                // Walking through the array looking for the item to return
                // When found, the item is returned.
                foreach (LibraryItem i in newLibrary.GetItemsList())
                {
                    if (i == selecteditem)
                    {
                        int positionOfItem = newLibrary.GetItemsList().IndexOf(i);    //position of the selected item

                        newLibrary.CheckOut(positionOfItem, checkout.PatronSelected); //returning the item 
                    }
                }
            }
        }


        // Precondition:  The return menu button is clicked.
        // Postcondition: The library item is returned.
        // 
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> checkedoutitems = new List<LibraryItem>();  // A list of checked out items is created
            DialogResult result;                                          // A dialog result is created

            // Walking through the library items list to find items that are checked out,
            // adding each checked-out item to the combo box in the form,
            // and also adding the item to the list of checked out items.
            foreach (LibraryItem i in newLibrary._items)
            {
                if (i.IsCheckedOut())
                {        
                    checkedoutitems.Add(i);
                }
            }

            // A return form is created
            Return returnbox = new Return(checkedoutitems);                             

            // Return form is shown
            result = returnbox.ShowDialog();

            if (result == DialogResult.OK)
            {
                //this is the item that the user wants to return
                var selecteditem = checkedoutitems.ElementAt(returnbox.ItemSelected);

                // Walking thu the library items list to find the item the user wishes to return
                // and returning it.
                foreach(LibraryItem i in newLibrary.GetItemsList())
                {
                    if (i == selecteditem)
                    {
                        int positionOfSelectedItem = newLibrary.GetItemsList().IndexOf(i);  //position of the selected item
                        
                        newLibrary.ReturnToShelf(positionOfSelectedItem);
                    }
                }
            }
        }

        //Precondition: The program executes
        //Postcondition: The main form is loaded.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Adding library items to the library
            // Book 
            // Journal
            // Magazine
            // Movie
            // Music
            newLibrary.AddLibraryBook("The Book", "New York publishers", 2009, 4, "Row 7", "Just Kidding Rowling");            
            newLibrary.AddLibraryJournal("The Journal", "Some Publisher", 2009, 67, "Top floor", 5, 10, "Library Research", "Papa John");                      
            newLibrary.AddLibraryMagazine("Forbes", "Some New York Publisher", 2016, 100, "Coffee Table", 1, 2);                                                                               
            newLibrary.AddLibraryMovie("The Departed", "Stanley Kubrick", 2012, 2, "Movie Cabinet", 2.40, "Martin Scorcese", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.R);   
            newLibrary.AddLibraryMusic("John Legend", "Good Pubplisher", 2009, 30, "CD Rack", 1.2, "John Legend", LibraryMediaItem.MediaType.CD, 13);

            newLibrary.AddPatron("Peter", "1234");      // Adding patron to library
            newLibrary.AddPatron("Pedro", "3456");      // Adding patron to library
            newLibrary.AddPatron("Petra", "3453");      // Adding patron to library
            newLibrary.AddPatron("Donald", "6789");     // Adding patron to library
            newLibrary.AddPatron("Gattis", "2321");     // Adding patron to library
            newLibrary.AddPatron("Donald Duck", "1203");// Adding patron to library
        }

        // Precondition:  None
        // Postcondition: An string value is returned with a trailing empty text line.
        // 
        public static string AppendLine(string value)
        {
            string outputvalue;               // String varaible that holds the returned string
            string NL = Environment.NewLine;  // String variable that holds a new line

            return outputvalue  = value + NL + NL ;
        }

    }
}

