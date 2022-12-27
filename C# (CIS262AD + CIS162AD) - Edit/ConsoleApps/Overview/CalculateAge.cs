using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class CalculateAge
    {
        private double birthMonth;
        private double birthYear;
        private double age;
        public const double CURRENT_YEAR = 2021;
        public const double CURRENT_MONTH = 4;
        public const string STUDENT_NAME = "Brendan's";
        public const string CLASS_NAME = "Age Calculator";
        public CalculateAge()
        {
            birthMonth = 0;
            birthYear = 0;
            age = 0;
        }
        public CalculateAge(double month, double year)
        {
            birthMonth = month;
            birthYear = year;
            age = 0;
        }
        public double BirthMonth
        {
            get { return birthMonth; }
            set { birthMonth = value; }
        }
        public double BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        public double Age
        {
            get { return age; }
            set { age = value; }
        }
        public double CurrentYear
        {
            get { return CURRENT_YEAR; }
        }
        public double CurrentMonth
        {
            get { return CURRENT_MONTH; }
        }
        public string StudentName
        {
            get { return STUDENT_NAME; }
        }
        public string ClassName
        {
            get { return CLASS_NAME; }
        }
        private void GetAge()
        {
            double years = CURRENT_YEAR - birthYear;

            double months;
            if (CURRENT_MONTH < birthMonth)
            {
                years--;
                months = 12 - birthMonth;
                months += CURRENT_MONTH;
                months = months / 12;
            }
            else
            {
                months = CURRENT_MONTH - birthMonth;
                months = months / 12;
            }

            age = years + months;
        }
        public override string ToString()
        {
            GetAge();
            return string.Format("\n\tYour age is: {0:F2}",age);
        }
    }
}
