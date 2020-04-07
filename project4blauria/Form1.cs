using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//The program creates a new list. The Add button allows you to add to the list whatever value you enter in the conjoining add textbox.
//The search button has a while loop that goes throught the individual records in you list and returns if the record contains what you searched for 
//or if it did not andi is also connected to a menu button for Search. The Clear button Clears your results in the Rich textbox and
//is also connected to a menu button for Clear. The Display all records button display every record with a loop that runs every record
//entered in rich textbox it is connected to a menu command thats labeled display all as well. The Show Record button - method allows you to
//to enter a number identifying record number and parse is the data so it can run an error message if evaluated to be wrong or bring the record up if 
//correct to be displayed. Delete Record eventhandler is connected to a button that deletes the record specified by user by parseing data input and then
//evaluating the record number displays error message if the wrong number or number invalid if accepted it deletes the record. Exit menu allows you to 
//Exit the program. The menu for save will open a dialog box called and default type to txt and name to cop2010 it will save
//what is in your richtextbox.
//
//Brandi Lauria
//04/14/2017
//
namespace project4blauria
{//begin namespace
    public partial class Form1 : Form
    {//begin class
        public Form1()
        {
            InitializeComponent();
        }
        //list of type strings called files

        List<string> files = new List<string>();

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //add code to input a string and add it to the files list

            files.Add(txtAddItem.Text.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {//begin search eventhandler
            //local variables declared
            //take search box user input and assigns to local variable
            string strSearchWord = txtSearch.Text.ToString();
            int intIndex = 0;
            //gets the file amount in the list
            int intCount = files.Count;
            //while statement loop for intindex smaller than length of array do stop when gets bigger than count
            while (intIndex < intCount)
            {//begin while
            //if file contains word print to screen while adding one to index
            if (files[intIndex].Contains(strSearchWord))

                {//begin if
                    txtRecordOutput.Text += ("Match found in Record " + (intIndex + 1) + ": " + files[(intIndex)] + "\n");
                    intIndex++;
                }//end if
                else if (!files[intIndex].Contains(strSearchWord))
                    //else add on but print record not found
                {//begin else
                    intIndex++;
                    { txtRecordOutput.Text += ("No Match found in Record " + intIndex + " \n"); }
                }//end else
             
            }//end while
            //let the search button be used from the menu button as well
                this.mnuSearchToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
             }//end eventhandler for search button

        private void btnClearResults_Click(object sender, EventArgs e)
     
        {
            //clear button eventhandler begins
            //Clear the display from clear button and the menu item
            txtRecordOutput.Clear();
            this.mnuClearResultsToolStripMenuItem.Click += new System.EventHandler(this.btnClearResults_Click);
        }//end eventhandler for clear display

        private void btnDisplayAllRecords_Click(object sender, EventArgs e)
        {//begin eventhandler for display all records
            
            {
                //add code for a loop to display the entire list
                // iniatilize variables
                int intIndex = 0;
                int intCount = 0;
                intCount = files.Count;
                
                //while (intIndex < files.count)
                while (intIndex < intCount)
                {//display records print out to screen
                    txtRecordOutput.Text +=" Record " + (intIndex + 1) +" : " + (files[intIndex]) + "\n";
                    intIndex++;
                }//end while
            }
            //menu item displays records
            this.mnuDisplayAllRecordsToolStripMenuItem.Click += new System.EventHandler(this.btnDisplayAllRecords_Click);

        }//end eventhandler for display all records
          

        private void btnShowRecord_Click(object sender, EventArgs e)
        {//begin event handler for show record
            //parse the record user wants to see so we can use the data
            int intNumberOfRecordToShow = int.Parse(txtShowRecord.Text);
            //Show error message if record they are looking for doesn't exist
            if (intNumberOfRecordToShow > files.Count || intNumberOfRecordToShow == 0)
                txtRecordOutput.Text = (" The record you are trying to show does not exist");
            //else no error message show the record they correctly entered
            else
            txtRecordOutput.Text = ("Record " + intNumberOfRecordToShow+": " + files[intNumberOfRecordToShow-1]);

        }//end eventhandler for show record

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {//begin eventhandler for deleting a record
            //parse number entered in text box -to be deleted
            int intNumberOfRecord = int.Parse(txtDeleteRecord.Text);
            //Error message if the entered an invalid record number that doesn't exist
            if (intNumberOfRecord > files.Count || intNumberOfRecord == 0)
                txtRecordOutput.Text = (" The record you are trying to delete does not exist");
            else//if files do exist delete record they entered
            files.RemoveAt(intNumberOfRecord-1);
        }//end eventhandler for deleteing a record

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {//begin eventhandler for exit
            //Exit application from menu item
            Application.Exit();
        }//end eventhandler for exit

        private void mnuSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {//begin eventhandler for save file
            //make new save file
            SaveFileDialog file = new SaveFileDialog();
            //save file default type txt
            file.DefaultExt = "*.txt";
            file.Filter = "Text File|*.txt";
            //default file name cop2010
            file.FileName = "COP2010.txt";
           //show pop up save box
            file.ShowDialog();
            //save file default type txt
            file.DefaultExt = "*.txt";
            //Save list in richboxtext
           txtRecordOutput.SaveFile(file.FileName, RichTextBoxStreamType.UnicodePlainText);

        }//end save eventhandler
    }//end class
    }//end namespace

