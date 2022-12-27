using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    // Brendan Ellison
    // 4/2/2021
    class ParallelArrays
    {
        private string[] firstName;
        private string[] lastName;
        private const string studentName = "Brendan's";
        private const string className = "Parallel Arrays";
        int[] id;
        public ParallelArrays(string[] fn, string[] ln, int[] iD)
        {
            FirstName = fn;
            LastName = ln;
            ID = iD;
        }
        public string[] FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string[] LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int[] ID
        {
            get { return id; }
            set { id = value; }
        }
        private string ArrayReader()
        {
            string message = "";
            for (int i = 0; i < firstName.Length; i++)
            {
                message += "\n\n\tEmployee name:\t" + firstName[i] + " " + lastName[i] + "\n\tEmployee ID:\t" + id[i].ToString();
                // Interesting seeing how tabs work. I assumed they were just spaces I guess not.
            }
            return message;
        }
        public override string ToString()
        {
            return ArrayReader();
        }
    }
}
