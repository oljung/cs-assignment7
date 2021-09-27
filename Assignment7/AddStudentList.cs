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
    public partial class AddStudentList : Form
    {
        private StudentList studentList;

        public AddStudentList(StudentList studentList)
        {
            InitializeComponent();
            this.studentList = studentList;
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            txtGroupName.Text = studentList.Name;
            txtStudents.Text = GetStudents();
        }
        /// <summary>
        /// Method used to prepare a string to go into textbox displaying
        /// names of students in the list
        /// </summary>
        /// <returns>string of name, with new line after each</returns>
        private string GetStudents()
        {
            string output = "";
            
            for(int i = 0; i < studentList.Students.Length; i++)
            {
                if(i == studentList.Students.Length - 1)//last item in array
                {
                    output += studentList.Students[i];
                }
                else//if not last item, add new line after name
                {
                    output += studentList.Students[i] + Environment.NewLine;
                }
            }
            return output;
        }


        private void AddStudentList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = (Form)sender;//create a local instance of form to check for DialogResult
            //if result is ok
            if(form.DialogResult == DialogResult.OK)
            {
                //checks if any of the controls are empty
                if(string.IsNullOrEmpty(txtGroupName.Text) || string.IsNullOrEmpty(txtStudents.Text))
                {
                    //user has not entered any values, closing is canceled
                    MessageBox.Show("Vänligen ange gruppnamn och elever", "Error");
                    e.Cancel = true;
                }
                else//all is fine, values added and form closed
                {
                    studentList.Name = txtGroupName.Text;
                    //splits string at each line and adds each new string to appropriate index in array
                    string[] allStrings = txtStudents.Text.Split('\n');
                    //remove all whitespaces
                    for (int i = 0; i < allStrings.Length; i++)
                    {
                        allStrings[i] = allStrings[i].Trim();
                    }
                    studentList.Students = allStrings;
                }
            }
            else//DialogResult is "Cancel"
            {
                string message = "Är du säker på att du vill stänga formuläret?\n" +
                    "Ändringar du gjort kommer inte att sparas";
                string title = "Säker?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                //check MessageBox DialogResult. If no, cancel closing.
                if(MessageBox.Show(message, title, buttons, icon) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
