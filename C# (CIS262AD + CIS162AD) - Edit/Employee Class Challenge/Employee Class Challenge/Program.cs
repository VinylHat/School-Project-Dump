using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Brendan Ellison
            // Employee Class Coding Challenge
            // November 11, 2020

            // get/set private data
            // Override ToString() method
            // 2 Objects

            Employee Employee1 = new Employee();
            // I assume in a real setting you might use and array so you can add to a list of objects
            // Because of the active bool status thing this context is kind dumb but it gives me something more to work with
            Console.WriteLine("Welcome to the database\nHere we will collect your information to make your entry\nLets start by getting your first name:");
            Employee1.FirstName = Console.ReadLine();
            Console.WriteLine("And now your last name:");
            Employee1.LastName = Console.ReadLine();
            Console.WriteLine("What is your position?");
            Employee1.Title = Console.ReadLine();

            // Just splitting these up besed on the input type to, hopefully, make it easier to read
            Console.WriteLine("How many hours a week do you plan on working?");
            string input = Console.ReadLine();
            double.TryParse(input, out double hours);
            Employee1.Hours = hours;
            Console.WriteLine("How much will you be making an hour?");
            input = Console.ReadLine();
            double.TryParse(input, out double hourlyPay);
            Employee1.HourlyRate = hourlyPay;

            // I see you must assign all variables to an object before it can return to the main, even if they are maningless
            // I am usre there is more going on here but I am wondering if there are work arounds or something im missing
            Employee1.EmployeeID = "123";
            Employee1.Status = "?";

            Console.Clear();
            Console.WriteLine(Employee1.ToString());
            Console.ReadKey();

            Console.Clear();
            // Test 2

            Employee Employee2 = new Employee();
            Console.WriteLine("Welcome to the database\nHere we will collect your information to make your entry\nLets start by getting your first name:");
            Employee2.FirstName = Console.ReadLine();
            Console.WriteLine("And now your last name:");
            Employee2.LastName = Console.ReadLine();
            Console.WriteLine("What is your position?");
            Employee2.Title = Console.ReadLine();

            Console.WriteLine("How many hours a week do you plan on working?");
            input = Console.ReadLine();
            double.TryParse(input, out hours);
            Employee2.Hours = hours;
            Console.WriteLine("How much will you be making an hour?");
            input = Console.ReadLine();
            double.TryParse(input, out hourlyPay);
            Employee2.HourlyRate = hourlyPay;

            Employee2.EmployeeID = "123";
            Employee2.Status = "?";

            Console.Clear();
            Console.WriteLine(Employee2.ToString());
            Console.ReadKey();
        }
    }
}
