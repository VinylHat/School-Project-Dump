using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    /*
     * Brendan Ellison
     * 4/26/2021
     * Inherent class of Employee.cs
     */
    class EmployeePay : Employee
    {
        private double hours;
        private double wage;  // can be biweekly or hourly
        private double sales;
        private double rate;
        public double Hours { get => hours; set => hours = value; }
        public double Wage { get => wage; set => wage = value; }
        public double Sales { get => sales; set => sales = value; }
        public double Rate { get => rate; set => rate = value; }

        public EmployeePay()
        {
            Hours = 0.0;
            Wage = 0.0;
        }
        public EmployeePay(double wage, double hours)
        {
            Hours = hours;
            Wage = wage;
        }
        public EmployeePay(string firstName, string lastName, string middleName,
            string payType, string employeeID, char gender, string phone, string eMail) :
            base(firstName, lastName, middleName, payType, employeeID, gender, phone, eMail)
        {
            
        }
        private double CalculatePay()
        {
            double pay;
            switch (PayType)
            {
                case "hourly":
                    if (Hours > 40) pay = (Wage * 40) + ((Hours - 40) * (Wage * 1.5));
                    else pay = Wage * Hours;
                    break;
                case "salary":
                    pay = Wage;
                    break;
                case "sales":
                    pay = (Sales * Rate) + wage;
                    break;
                default:
                    pay = 0.0;
                    break;
            }
            return pay;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("\n\t{0,-20} {1,-8:C2}","Pay: ",CalculatePay());
        }
    }
}
