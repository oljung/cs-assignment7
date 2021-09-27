using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{/// <summary>
/// Class that stores an array of students' names to be used in a List<T>
/// in a manager class
/// </summary>
    public class StudentList
    {
        //name of the group
        private string name;
        //array of students in the group
        private string[] students;
        /// <summary>
        /// Property linked to the name field. Both read and write access
        /// value validated to not be empty bevore set
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        /// <summary>
        /// Property linked to the students field.
        /// Both read and write access
        /// </summary>
        public string[] Students
        {
            get { return students; }
            set { students = value; }
        }
        /// <summary>
        /// Default constructor, calls constructor with two parameters
        /// </summary>
        public StudentList():this(string.Empty, null)
        {

        }
        /// <summary>
        /// Constructor with two parameters.
        /// </summary>
        /// <param name="name">sets the instance field name</param>
        /// <param name="students">sets the instance field students</param>
        public StudentList(string name, string[] students)
        {
            this.name = name;
            this.students = students;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">the object that is to be copied</param>
        public StudentList(StudentList other)
        {
            this.name = other.name;
            this.students = CopyArray(other.students);
        }
        /// <summary>
        /// Method used for creating a deep copy of the array for use in copy constructor
        /// </summary>
        /// <param name="other">array to copy</param>
        /// <returns>copied array</returns>
        private string[] CopyArray(string[] other)
        {
            //create an array of equal size as the one to copy
            string[] output = new string[other.Length];
            //iterate through the arrays and copy items
            for(int i = 0; i < other.Length; i++)
            {
                output[i] = other[i];
            }
            return output;
        }
        
    }
}
