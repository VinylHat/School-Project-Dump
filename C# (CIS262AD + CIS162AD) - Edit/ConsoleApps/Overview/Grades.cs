using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    // Brendan Ellison
    // March 5th, 2021
    class Grades
    {
        private double score;
        private string grade;
        public string name;
        public string clas;
        // I guess you cant name a string "class", makes sense. 
        public Grades()
        {
            score = 0.0;
            name = "Brendan";
            clas = "OOP Fundementals";
            grade = "";
        }
        public Grades(double scr)
        {
            score = scr;
        }
        public double Score
        {
            get { return score; }
            set { score = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Class
        {
            get { return clas; }
        }
        private void LetterGrader()
        {
            if (score >= 90 && score <= 100)
            {
                grade = "A";
            }
            else if (score < 90 && score >= 80)
            {
                grade = "B";
            }
            else if (score < 80 && score >= 70)
            {
                grade = "C";
            }
            else if (score < 70 && score >= 60)
            {
                grade = "D";
            }
            else if (score >= 0 && score < 60)
            {
                grade = "F";
            }
            else
            {
                grade = "Invalid";
            }
        }
        public override string ToString()
        {
            LetterGrader();
            return "\n\tA score of " + score.ToString("N2") + " earns you a grade of " + grade;
        }

    }
}
