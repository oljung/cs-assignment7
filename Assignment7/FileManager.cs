using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment7
{
    class FileManager
    {
        private const string fileToken = "StudRan_21";
        /// <summary>
        /// This method is used to save information in a StudentListManager object contained in
        /// a List<StudentList> using a fileName passed to the method
        /// </summary>
        /// <param name="studentLists">list of objects to be saved</param>
        /// <param name="fileName">path where file is located, if no file exists on will be created</param>
        /// <returns></returns>
        public bool SaveStudentListsToFile(List<StudentList> studentLists, string fileName)
        {
            bool ok = true;
            //must be declared here to be used in the whole method
            StreamWriter writer = null;
            try//try to write to file
            {
                //open writer with filename
                writer = new StreamWriter(fileName);
                //write fileToken for comparison
                writer.WriteLine(fileToken);
                //write number of StudentList objects to be saved, for use when reading
                writer.WriteLine(studentLists.Count);
                //for every object of StudentList in list, do this
                for(int i = 0; i < studentLists.Count; i++)
                {
                    //save the value of name variable of StudentList object
                    writer.WriteLine(studentLists[i].Name);
                    //write number of items in array, for use when reading
                    writer.WriteLine(studentLists[i].Students.Length);
                    //for each item in array, write to file
                    foreach(string student in studentLists[i].Students)
                    {
                        writer.WriteLine(student);
                    }
                }
            }
            catch
            {
                //if something went wrong, prevents crash
                ok = false;
            }
            finally
            {
                //close writer if one exists
                if(writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// This works pretty much exactly like the save method, but in reverse
        /// </summary>
        /// <param name="studentLists"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool ReadStudentListsFromFile(List<StudentList> studentLists, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                if(studentLists != null)
                {
                    //if studentLists has information, clear it to only have information from
                    //file when operation is completed
                    studentLists.Clear();
                }
                else
                {
                    //studentLists is null, create a new
                    studentLists = new List<StudentList>();
                }
                //open a reader using fileName
                reader = new StreamReader(fileName);
                //read string for testing file
                string tokenTest = reader.ReadLine();
                if(tokenTest == fileToken)
                {
                    int count = int.Parse(reader.ReadLine());
                    for(int i = 0; i < count; i++)
                    {
                        //create a new StudentList
                        StudentList studentList = new StudentList();
                        studentList.Name = reader.ReadLine();
                        //reads number of strings in array saved
                        int arrayCount = int.Parse(reader.ReadLine());
                        //creates a new array using arrayCount
                        studentList.Students = new string[arrayCount];
                        //reads number of lines == number of elements in array
                        for(int j = 0; j < arrayCount; j++)
                        {
                            //read each line and save value to index in array
                            studentList.Students[j] = reader.ReadLine();
                        }
                        //add the new object of StudentList to the list
                        studentLists.Add(studentList);
                    }
                }
                else//not same token
                {
                    ok = false;
                }
            }
            catch
            {
                //something went wrong with file
                ok = false;
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
            return ok;
        }
    }
}
