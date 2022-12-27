using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Chp2Exc6
    {
        // Attributes
        private double height;
        private double weight;
        private double bmi;

        const double CONV_HEIGHT = 0.0254;
        const double CONV_WEIGHT = 0.453592;

        // Behaviors
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private double BMI
        {
            get { return bmi; }
            set { bmi = value; }
        }
        public void calcBMI()
        {
            Height *= CONV_HEIGHT;
            Weight *= CONV_WEIGHT;
            BMI = Weight / (Math.Pow(Height, 2));
        }
        // Constructors
        public Chp2Exc6()
        {
            Height = 0;
            Weight = 0;
            BMI = 0;
        }
        public Chp2Exc6(double h, double w)
        {
            Height = h;
            Weight = w;
            BMI = 0;
        }
        public override string ToString()
        {
            calcBMI();
            return string.Format(
                "\n\tFor a person who weights {0:F2} kilos and has a height of {1:F2} meters," +
                "\n\ttheir Body Mass Index is {2:F2}", Weight, Height, BMI);
        }
    }
}
