using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    // Brendan Ellison
    // March 8th, 2021
    class CollegeAdmissions
    {
        //class variables
        public int classRank;
        public int testScore;
        public string message;
        private const string studentName = "Brendan Ellison";
        private const string className = "Collage Admissions";
        //default constructor
        public CollegeAdmissions()
        {
            classRank = 0;
            testScore = 0;
            message = "";
        }
        //two argument constructor
        public CollegeAdmissions(int ts, int cr)
        {
            classRank = cr;
            testScore = ts;
            message = "";
        }
        public int ClassRank
        {
            get { return classRank; }
            set { classRank = value; }
        }
        public int TestScore
        {
            get { return testScore; }
            set { testScore = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public string Name
        {
            get { return studentName; }
        }
        public string ClassName
        {
            get { return className; }
        }
        private void AcceptReject()
        {
            // Test using admission requirements and print Accept or Reject      
            if (testScore >= 90)
            {
                message = "Accept";
            }
            else if (testScore >= 80 && classRank <= 75)
            {
                message = "Accept";
            }
            else if (testScore >= 70 && classRank <= 50)
            {
                message = "Accept";
            }
            else
                message = "Reject";
        }
        public override string ToString()
        {
            AcceptReject();
            return "\n\t" + message + "\t" + testScore + "\t" + classRank;
        }
    }
}