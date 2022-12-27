using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    // Brendan Ellison
    // 5/17/2021
    class FinalExam
    {
        private string make;
        private string model;
        private int year;
        private string color;
        private double price;

        public FinalExam()
        {
            Make = "";
            Model = "";
            Year = 0;
            Color = "";
            Price = 0.0;
        }

        public FinalExam(string make, string model, int year, string color, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Price = price;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return string.Format("\n\t{0,-9}{1,-10}{2,-9}{3,-10}{4:C2}",Make,Model,Year,Color,Price);
        }
    }
}
