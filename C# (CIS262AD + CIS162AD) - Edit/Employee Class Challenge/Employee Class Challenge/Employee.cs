using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee_Class_Challenge
{
    class Employee
    {
        private string employeeID; // Read Only
        private string firstName;
        private string lastName;
        private double hourlyPay;
        private double hours;
        private string title;
        private string status; // Read Only
        private double gross;

        // I don't think I fully understand constructors
        public Employee()
        {

        }
        // I wanted to try something with the FullName but it didnt seem to work
        public Employee(string FullName)
        {
            FullName = firstName + " " + lastName;
            employeeID = BuildID();
            status = EmployeeStatus();
            gross = GetGross();
        }
        private string BuildID()
        {
            if (firstName.Length > 0)
            {
                Random rnd = new Random();
                return firstName.Substring(0, 3) + (rnd.Next(9999999).ToString());
            }
            else
                return "XXX9999";
        }
        // Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = BuildID(); }
        }
        public double HourlyRate
        {
            get { return hourlyPay; }
            set { hourlyPay = value; }
        }
        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = EmployeeStatus(); }
        }
        public double Gross
        {
            get { return gross; }
            set { gross = GetGross(); }
        }
        public double GetGross()
        {
            double value = hourlyPay * hours;
            return value;
        }
        // It is unclear what you mean with a read only bool, so I hope this is what you are looking for
        public string EmployeeStatus()
        {
            if (hours > 0)
            {
                return "Active";
            }
            else
                return "Inactive";
        }
        public override string ToString()
        {
            string message = "Hello, " + firstName + " " + lastName +
                             "\nYour employee ID is: " + employeeID.ToString() + 
                             "\nYou are wroking " + hours + " for " + hourlyPay.ToString("C") + " an hour, netting you " + GetGross().ToString("C") + 
                             "\nEmployee status: " + status.ToString();
            return message;
        }
    }
}
