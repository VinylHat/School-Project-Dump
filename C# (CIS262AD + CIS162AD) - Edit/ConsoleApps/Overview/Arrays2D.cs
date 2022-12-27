using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Array2D
    {
        /*  Brendan Ellison
         *  4/14/2021
         *  
         *  Adding to an 2D array with 6 rows 5 columns
         *  contains price per day of day care based on days per week attended + age of child
         */

        private int row;
        private int column;
        private double cost;
        private double[,] rate;
        private const string Student_Name = "Brendan's";
        private const string Class_Name = "2D Arrays";
        public Array2D()
        {
            // I am temped to leave this out because we don't use a default constructor
            // I just reused the array because I was lazy
            row = 0;
            column = 0;
            cost = 0;
            rate = new double[,] {
                { 30.00, 60.00, 88.00,115.00, 140.00},
                { 26.00, 52.00, 70.00, 96.00, 120.00},
                { 24.00, 40.00, 60.00, 75.00, 88.00},
                { 22.00, 40.00, 60.00, 75.00, 88.00},
                { 20.00, 35.00, 50.00, 66.00, 84.00}
            };
        }
        public Array2D(int price, int age, double[,] costTable)
        {
            cost = 0;
            row = age;
            column = price - 1;
            // almost didn't notice
            rate = costTable;
        }
        public string StudentName
        {
            get { return Student_Name; }
        }
        public string ClassName
        {
            get { return Class_Name; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Column
        {
            get { return column; }
            set { column = value; }
        }
        public double[,] Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private void  GetPriceOfService()
        {
            if (row > 4) 
                row = 4;
            if (row < 0) 
                row = 0;
            if (column > 4) 
                column = 4;
            if (column < 0) 
                column = 0;
            // Just to avoid "possible" errors

            cost = rate[row,column];
        }
        public override string ToString()
        {
            GetPriceOfService();
            return "\n\t" + cost.ToString("C2");
        }
    }
}
