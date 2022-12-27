using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    /*
     * Brendan Ellison
     * 4/21/2021
     * Employee class
     */
    class Employee
    {
        public const string STUDENT_NAME = "Brendan's";
        public const string CLASS_NAME = "Parent Class of Employee";
        private string firstName;
        private string lastName;
        private string middleName;
        private string payType;
        private string employeeID;
        private char gender;
        private string city;
        private string state;
        private string street;
        private string zipCode;
        private string phone;
        private string eMail;
        public string StudentName
        {
            get { return STUDENT_NAME; }
        }
        public string ClassName
        {
            get { return CLASS_NAME; }
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string PayType { get => payType; set => payType = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public char Gender { get => gender; set => gender = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Street { get => street; set => street = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string Phone { get => phone; set => phone = value; }
        public string EMail { get => eMail; set => eMail = value; }

        public Employee()
        {
            FirstName = "";
            LastName = "";
            MiddleName = "";
            PayType = "";
            EmployeeID = "";
            Gender = '\0';
            City = "";
            State = "";
            ZipCode = "";
            Street = "";
            Phone = "";
            EMail = "";
        }
        public Employee(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PayType = "";
            EmployeeID = "";
            Gender = '\0';
            City = "";
            State = "";
            ZipCode = "";
            Street = "";
            Phone = "";
            EMail = "";
        }
        public Employee(string firstName, string middleName, string lastName,
            string payType, string employeeID, char gender)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PayType = payType;
            EmployeeID = employeeID;
            Gender = gender;
            City = "";
            State = "";
            ZipCode = "";
            Street = "";
            Phone = "";
            EMail = "";
        }

        public Employee(string firstName, string lastName, string middleName,
            string payType, string employeeID,
            char gender,string phone, string eMail)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PayType = payType;
            EmployeeID = employeeID;
            Gender = gender;
            Phone = phone;
            EMail = eMail;
            City = "";
            State = "";
            ZipCode = "";
            Street = "";
        }

        public override string ToString()
        {
            return String.Format("\n\t{0,-20} {1,-8}\n\t{2,-20} {3,-8}\n\t{4,-20} {5,-8}" +
                "\n\t{6,-20} {7,-8}\n\t{8,-20} {9,-8}\n\t{10,-20} {11,-8}" +
                "\n\t{12,-20} {13,-8}\n\t{14,-20} {15,-8}\n\t{16,-20} {17,-8}\n\t{18,-20} {19,-8}" +
                "\n\t{20,-20} {21,-8}" + "\n\t{22,-20} {23,-8}", "First Name: ",
                FirstName, "Middle Name: ", MiddleName, "Last Name: ", LastName, "Pay Type: ", PayType, "Employee ID: ", EmployeeID,
                "Gender: ", Gender, "City: ", City, "State: ", State, "Street: ", Street, "Zip Code: ", ZipCode, "Phone: ", Phone, "E-mail: ", EMail);
        }
    }
}
