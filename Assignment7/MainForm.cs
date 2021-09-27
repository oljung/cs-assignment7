using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class MainForm : Form
    {
        //creates an instance of StudentListmanager
        private StudentListManager listManager = new StudentListManager();
        private string fileName = string.Empty;
        //this bool is used to keep track of saves after changes has been made
        private bool saved = false;
        
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// This method sets the app to "default starting mode" by clearing
        /// all control information, disabling buttons that shouldn't be enabled and
        /// clearing the current list.
        /// </summary>
        private void InitializeGUI()
        {
            cboxChooseClass.Items.Clear();
            lblStudent.Text = string.Empty;
            lstStudentList.Items.Clear();
            if (listManager.CurrentList != null)
                listManager.ClearCurrentList();
            txtAddDelete.Text = string.Empty;
            UpdateButtons(false);
        }
        /// <summary>
        /// Method used for setting enabled status on buttons that should only
        /// be enabled at certain times
        /// </summary>
        /// <param name="status"></param>
        private void UpdateButtons(bool status)
        {
            btnAddStudent.Enabled = status;
            btnDeleteList.Enabled = status;
            btnDeleteStudent.Enabled = status;
            btnEdit.Enabled = status;
            btnRandomStudent.Enabled = status;
            btnChoose.Enabled = status;
        }
        /// <summary>
        /// Overloaded method used for setting status on buttons based
        /// on list count and selected index value
        /// </summary>
        private void UpdateButtons()
        {
            if(listManager.CurrentList != null)//makes sure a list exists
            {
                //if there are no items left in the current list
                if (listManager.CurrentList.Count <= 0)
                {
                    btnAddStudent.Enabled = true;//you should still be able to add a name
                    btnDeleteStudent.Enabled = false;//no names left to delete
                    btnRandomStudent.Enabled = false;//no students left to draw
                }
                else
                {
                    btnRandomStudent.Enabled = true;
                    btnDeleteStudent.Enabled = true;
                    btnAddStudent.Enabled = true;
                }
            }

            //check index of combobox to determine status of edit list and delete list buttons
            if(cboxChooseClass.SelectedIndex < 0)
            {
                //index is less than 0, meaning nothing is selected
                btnDeleteList.Enabled = false;
                btnEdit.Enabled = false;
                btnChoose.Enabled = false;
            }
            else
            {
                //index at 0 and above means something is selected
                btnDeleteList.Enabled = true;
                btnEdit.Enabled = true;
                btnChoose.Enabled = true;
            }
        }
        /// <summary>
        /// This method is used to update the GUI after changes have been made to either
        /// the List<StudentList> studentLists or the List<string> currentList to properly
        /// display information
        /// </summary>
        private void UpdateGUI()
        {
            lblStudent.Text = string.Empty;
            txtAddDelete.Text = string.Empty;
            lstStudentList.Items.Clear();
            cboxChooseClass.Items.Clear();
            UpdateButtons();
            if (listManager.ListCount > 0)//if there are items in the List<StudentList>
            {
                //sets the items in combobox to the names of each object in studentLists
                cboxChooseClass.Items.AddRange(listManager.GetStudentListNames());
            }
            if(listManager.CurrentList != null)
            {
                if (listManager.CurrentList.Count > 0)//if there is an active current list with items in it
                {
                    //displays the students that are in the current list of students
                    lstStudentList.Items.AddRange(listManager.CurrentList.ToArray());
                }
            }

        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            //creates a new instance of StudentList
            StudentList studentList = new StudentList();
            //creates a form of AddStudentList and passes the object of StudentList as reference
            Form addList = new AddStudentList(studentList);
            addList.Text = "Lägg till en ny klass/grupp";
            //opens form as Dialog to handle result
            DialogResult dialogResult = addList.ShowDialog();
            //check if result is ok, then add the object to list and update GUI
            if(dialogResult == DialogResult.OK)
            {
                listManager.AddStudentList(studentList);
                UpdateGUI();
                saved = false;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            bool ok = listManager.CreateList(cboxChooseClass.SelectedIndex);
            if (ok)
            {
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Något gick fel, har du valt en grupp ur rullgardinen?", "Error");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool indexOk = true;
            if(cboxChooseClass.SelectedIndex < 0)//no index selected
            {
                indexOk = false;
            }
            if (indexOk)
            {
                //creates a copy of student list object at combobox index to pass as reference to form
                StudentList studentList = new StudentList(listManager.GetStudentList(cboxChooseClass.SelectedIndex, out bool ok));
                if (ok)
                {
                    //create a form from AddStudentList
                    Form editList = new AddStudentList(studentList);
                    editList.Text = "Ändra en klass/grupp";
                    //open form as dialog to handle result
                    DialogResult dialogResult = editList.ShowDialog();
                    //if result is ok, call EditStudentList and edit object at selected index
                    if (dialogResult == DialogResult.OK)
                    {
                        listManager.EditStudentList(cboxChooseClass.SelectedIndex, studentList);
                        UpdateGUI();
                        saved = false;
                    }
                }
            }
            else
            {
                {
                    MessageBox.Show("Du har inte valt någon klass/grupp att ta bort");
                }
            }
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            bool indexOk = true;
            if(cboxChooseClass.SelectedIndex < 0)
            {
                indexOk = false;
            }
            if (indexOk)
            {
                string message = "Du är på väg att radera en klass/grupp.\n" +
                "Är du säker? Du kommer att radera den grupp som är vald i rullgardinen just nu";
                string title = "Säker?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                //shows a confirmation message before removing, if yes procedure will continue
                if (MessageBox.Show(message, title, buttons, icon) == DialogResult.Yes)
                {
                    bool ok = listManager.DeleteStudentList(cboxChooseClass.SelectedIndex);
                    saved = false;
                    UpdateGUI();
                }
            }
            else
            {
                {
                    MessageBox.Show("Du har inte valt någon klass/grupp att ta bort");
                }
            }

        }

        private void btnRandomStudent_Click(object sender, EventArgs e)
        {
            bool ok = listManager.ChooseStudent(out string elev);
            if (ok)
            {
                lstStudentList.SelectedItem = elev;
                lblStudent.Text = elev;
            }
            else
                MessageBox.Show("Du har gått igenom hela listan," +
                    "välj en klass för att slumpa fler elever", "Error");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            bool ok = listManager.AddStudent(txtAddDelete.Text);
            if (ok)
            {
                UpdateGUI();
            }
            if (!ok)
            {
                MessageBox.Show("Du har inte angett ett namn att lägga till.", "Error");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            bool ok = listManager.DeleteStudent(txtAddDelete.Text);
            if (ok)
            {
                UpdateGUI();
            }
            if (!ok)
            {
                MessageBox.Show("Eleven hittades inte i listan", "Error");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Vill du spara ändringar innan du påbörjar ny fil?";
            string title = "Spara ändringar?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);
            if (dialogResult == DialogResult.Yes)
            {
                //save first
                saveToolStripMenuItem_Click(sender, e);
                //all that is needed to "start new" is to call InitializeGUI()
                InitializeGUI();
            }
            else if (dialogResult == DialogResult.No)
            {
                //all that is needed to "start new" is to call InitializeGUI()
                InitializeGUI();
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            //show savedialogbox
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //sets filepath to selected from saveFileDialog
                fileName = saveFileDialog1.FileName;
                //uses selected path to save data
                ok = listManager.WriteDataToFile(fileName);
                //changes have been saved
                saved = true;
            }
            if (!ok)
            {
                MessageBox.Show("Något gick fel när filen skulle sparas", "Error");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fileName == string.Empty)//no path selected yet
            {
                //no fileName, open saveFileDialog
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                listManager.WriteDataToFile(fileName);
                saved = true;
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (!saved)//if changes made has not been saved
            {
                string message = "Vill du spara ändringar innan du öppnar ny fil?";
                string title = "Spara ändringar?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult dialogResult = MessageBox.Show(message, title, buttons);
                //yes, user wants to save
                if (dialogResult == DialogResult.Yes)
                {
                    //save first
                    saveToolStripMenuItem_Click(sender, e);
                    if(openFileDialog1.ShowDialog()== DialogResult.OK)
                    {
                        //set fileName field to selected file path
                        fileName = openFileDialog1.FileName;
                        ok = listManager.ReadDataFromFile(fileName);
                        
                    }
                }
                else if(dialogResult == DialogResult.No)
                {
                    //go ahead without saving
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //set fileName field to selected file path
                        fileName = openFileDialog1.FileName;
                        ok = listManager.ReadDataFromFile(fileName);
                        
                    }
                }
            }
            else
            {
                //already saved, go ahead and open
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //set fileName field to selected file path
                    fileName = openFileDialog1.FileName;
                    ok = listManager.ReadDataFromFile(fileName);
                }
            }
            if (ok)
            {
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Något gick fel när filen skulle läsas", "Error");
            }
        }

        private void exitaltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close application, confirmation is handled in another method
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)//if changes made has not been saved
            {
                string message = "Vill du spara ändringar innan du avslutar programmet?";
                string title = "Spara ändringar?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult dialogResult = MessageBox.Show(message, title, buttons);
                //yes, user wants to save
                if (dialogResult == DialogResult.Yes)
                {
                    //save first
                    saveToolStripMenuItem_Click(sender, e);
                }
                //close without saving
                else if(dialogResult == DialogResult.Cancel)
                {
                    //user wants to cancel closing the form
                    e.Cancel = true;
                }
                //if user selects NO, form will close without saving
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates an object of aboutbox and opens it
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void cboxChooseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when index is changed, checks if edit and delete should be activated
            if (cboxChooseClass.SelectedIndex < 0)
            {
                //index is less than 0, meaning nothing is selected
                btnDeleteList.Enabled = false;
                btnEdit.Enabled = false;
                btnChoose.Enabled = false;
            }
            else
            {
                //index at 0 and above means something is selected
                btnDeleteList.Enabled = true;
                btnEdit.Enabled = true;
                btnChoose.Enabled = true;
            }
        }
    }
}
