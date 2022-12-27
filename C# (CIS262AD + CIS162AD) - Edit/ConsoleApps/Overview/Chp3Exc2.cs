using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Chp3Exc2
    {
        private double x;
        private double y;
        private double result;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Result
        {
            get { return result; }
            set { result = value; }
        }
        private double addTwoNumbers()
        {
            return X + Y;
        }
        private double subtractTwoNumbers()
        {
            return X - Y;
        }
        private double multiplyTwoNumbers()
        {
            return X * Y;
        }
        private double divideTwoNumbers()
        {
            return X / Y;
        }
        public Chp3Exc2()
        {
            X = 0;
            Y = 0;
            Result = 0;
        }
        public Chp3Exc2(double a, double b)
        {
            X = a;
            Y = b;
            Result = 0;
        }
        public override string ToString()
        {
            return String.Format(
                "\n\n\tThe two numbers are {0:F2} and {1:F2}" + 
                "\n\n\tResult of addition is {2:F2}" +
                "\n\n\tResult of subtraction is {3:F2}" + 
                "\n\n\tResult of multiplication is {4:F2}" +
                "\n\n\tResult of division is {5:F2}",
                X, Y, addTwoNumbers(), subtractTwoNumbers(), multiplyTwoNumbers(), divideTwoNumbers());
        }
    }
}
