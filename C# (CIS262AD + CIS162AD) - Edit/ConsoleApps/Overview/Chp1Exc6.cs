using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Chp1Exc6
    {
        private double number1;
        private double number2;

        public double Num1
        {
            get { return number1; } //accessor
            set { number1 = value; } //mutator
        }
        public double Num2
        {
            get { return number2; }
            set { number2 = value; }
        }
        public Chp1Exc6()
        {
            number1 = 0;
            number2 = 1;
        }
        public Chp1Exc6(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }
        private double AddTwo()
        {
            return number1 + number2;
        }
        private double SubtractTwo()
        {
            return number1 - number2;
        }
        private double MultiTwo()
        {
            return number1 * number2;
        }
        private double DivideTwo()
        {
            return number1 / number2;
        }
        private double RemainderTwo()
        {
            return number1 % number2;
        }
        public override string ToString()
        {
            string value = "";
            value += AddTwo();

            return "\n\tThe sum of both numbers is:\t" + value.ToString() +
                "\n\tThe difference of both numbers is:\t" + SubtractTwo().ToString() +
                 "\n\tThe multiplication of both numbers is:\t" + MultiTwo().ToString() +
                 "\n\tAnd the quotient of both numbers is:\t" + DivideTwo().ToString()
                 + " with a remainder of:\t" + RemainderTwo().ToString();
        }
    }
}
