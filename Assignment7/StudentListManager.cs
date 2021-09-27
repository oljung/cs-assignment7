using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{/// <summary>
/// Class with methods for handling StudentLists. This method can be used 
/// by a main form for handling information and saving/opening files.
/// The class also has a List<string> for handling a current list of students
/// </summary>
    class StudentListManager
    {
        //list for holding multiple objects of StudentList
        private List<StudentList> studentLists = new List<StudentList>();
        //list of strings for drawing random students and keeping track of who has been 
        //drawn and who are left. Also allows for temporarily adding and removing from a StudentList
        private List<string> currentList;
        
        /// <summary>
        /// Property that returns the current count of studentLists.
        /// Read acccess only
        /// </summary>
        public int ListCount
        {
            get { return studentLists.Count; }
        }

        /// <summary>
        /// Property that returns the current count of currentList.
        /// Read access only
        /// </summary>
        public List<string> CurrentList
        {
            get { return currentList; }
        }

        /// <summary>
        /// This method simply adds the object of StudentList passed to the method
        /// </summary>
        /// <param name="studentList">object of StudentList to add</param>
        public void AddStudentList(StudentList studentList)
        {
            studentLists.Add(studentList);
        }

        /// <summary>
        /// This method is used to change an item in the list using an index
        /// and an object of Student List to replace the item with.
        /// </summary>
        /// <param name="index">index where the item to change is located</param>
        /// <param name="studentList">the object that will replace previous object</param>
        /// <returns></returns>
        public bool EditStudentList(int index, StudentList studentList)
        {
            bool ok = false;
            //check that index is within the index of studentLists
            if(index >= 0 && index < studentLists.Count)
            {
                if(studentList != null)//makes sure the object is not null to prevent null reference exception
                {
                    //changes the item at index to a copy of the passed StudentList object
                    studentLists[index] = new StudentList(studentList);
                    //operation successful
                    ok = true;
                }
            }
            return ok;
        }

        /// <summary>
        /// Method of removing an item from the studentLists at 
        /// selected index
        /// </summary>
        /// <param name="index">index where item to remove is located</param>
        /// <returns></returns>
        public bool DeleteStudentList(int index)
        {
            bool ok = false;
            //check that index is whithin range of studentLists.Count
            if (index >= 0 && index < studentLists.Count)
            {
                studentLists.RemoveAt(index);
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// This method is used to get a studentList object from the List<StudentList>
        /// from the outref based on index passed
        /// </summary>
        /// <param name="index">index where object is stored</param>
        /// <param name="success">true if successful, false if not</param>
        /// <returns>object of StudentList class</returns>
        public StudentList GetStudentList(int index, out bool success)
        {
            StudentList studentList = null;
            bool ok = false;
            //check index
            if(index >= 0 && index < studentLists.Count)
            {
                //if index valid, sets local variable to object stored at index
                studentList = studentLists[index];
                ok = true;
            }
            success = ok;
            return studentList;
        }

        /// <summary>
        /// Method for creating a List<string> of students to be used when selecting 
        /// random students from the array of the StudentList object stored at the passed index
        /// </summary>
        /// <param name="index">index to get list from</param>
        /// <returns></returns>
        public bool CreateList(int index)
        {
            
            bool ok = false;
            //check that index is whithin range of studentLists.Count
            if (index >= 0 && index < studentLists.Count)
            {
                currentList = new List<string>();//create a new list
                //iterate through the array of selected object and att each item to the currentList
                foreach (string student in studentLists[index].Students)
                {
                    currentList.Add(student);
                }
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// This method is used to randomly draw a "student" (stringitem) from the 
        /// currentList and then remove that same item to ensure that one is not 
        /// randomly selected multiple times.
        /// </summary>
        /// <param name="outStudent">the randomly selected student</param>
        /// <returns></returns>
        public bool ChooseStudent(out string outStudent)
        {
            bool ok = true;
            string student = "";
            //makes sure there are students left in currentList
            if(currentList.Count <= 0)
            {
                ok = false;
            }
            if (ok)
            {
                //creates an object of Random
                Random r = new Random();
                //generate an index between 0 and the amount of items in currentList
                int index = r.Next(0, currentList.Count);
                student = currentList[index];
                //remove the selected item to ensure that the same student isn't drawn again
                currentList.RemoveAt(index);
            }
            outStudent = student;
            return ok;
        }

        /// <summary>
        /// This method will add a string passed from parameter to the 
        /// currentList of the class
        /// </summary>
        /// <param name="student">string to be added to the List<string></param>
        /// <returns></returns>
        public bool AddStudent(string student)
        {
            bool ok = true;
            //check if string is empty
            if (string.IsNullOrEmpty(student))
            {
                ok = false;
            }
            if (ok)
            {
                //add the student to the current list
                currentList.Add(student);
            }
            return ok;
        }

        /// <summary>
        /// This method will remove a student from the currentList 
        /// by first checking if it is in the list, of so removing it
        /// </summary>
        /// <param name="student">string to be removed from the List<string></param>
        /// <returns></returns>
        public bool DeleteStudent(string student)
        {
            //check if currentList contains the string passes to the method
            bool ok = currentList.Contains(student);
            if (ok)
            {
                //if string is in List, remove it
                currentList.Remove(student);
            }
            return ok;
        }

        /// <summary>
        /// This method prepares an array of strings to go in a combobox
        /// for displaying the different objects of studentLists
        /// </summary>
        /// <returns></returns>
        public string[] GetStudentListNames()
        {
            //creates an array of equal size as studentLists
            string[] output = new string[studentLists.Count];
            //iterate over array and set each index item to same value as name of object at that index
            for(int i = 0; i < studentLists.Count; i++)
            {
                output[i] = studentLists[i].Name;
            }
            return output;
        }
        /// <summary>
        /// Method for clearing the currentList from strings to ensure "fresh start"
        /// </summary>
        public void ClearCurrentList()
        {
            currentList.Clear();
        }
        /// <summary>
        /// Write data to file using the instance variable studentLists and the
        /// parameter fileName
        /// </summary>
        /// <param name="fileName">path where data is saved</param>
        /// <returns>true if success, false if not</returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            //call method to write to file using the filename argument and the studentLists field
            return fileManager.SaveStudentListsToFile(studentLists, fileName);
        }
        /// <summary>
        /// Read data from file to instance varible studentLists using the file
        /// at parameter fileName
        /// </summary>
        /// <param name="fileName">path where the file to rad from is stored</param>
        /// <returns></returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            //call method to read from file using the filename argument and the studentLists field
            return fileManager.ReadStudentListsFromFile(studentLists, fileName);
        }
    }
}
