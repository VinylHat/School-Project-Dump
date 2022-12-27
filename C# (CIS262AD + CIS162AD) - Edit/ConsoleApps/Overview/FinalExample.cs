using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    // Brendan Ellison
    // 5/12/2021
    // Demonstration of Final Exam
    class FinalExample
    {
        private string houseType;
        private string houseColor;
        private string houseTrimColor;
        private int numBed;
        private int numBath;
        private int squareFeet;
        private string roofType;
        public FinalExample()
        {

        }

        public FinalExample(string houseType, string houseColor, string houseTrimColor, int numBed, int numBath, int squareFeet, string roofType)
        {
            HouseType = houseType;
            HouseColor = houseColor;
            HouseTrimColor = houseTrimColor;
            NumBed = numBed;
            NumBath = numBath;
            SquareFeet = squareFeet;
            RoofType = roofType;
        }

        public string HouseType { get => houseType; set => houseType = value; }
        public string HouseColor { get => houseColor; set => houseColor = value; }
        public string HouseTrimColor { get => houseTrimColor; set => houseTrimColor = value; }
        public int NumBed { get => numBed; set => numBed = value; }
        public int NumBath { get => numBath; set => numBath = value; }
        public int SquareFeet { get => squareFeet; set => squareFeet = value; }
        public string RoofType { get => roofType; set => roofType = value; }

        public override string ToString()
        {
            return string.Format("\t{0,-14}{6,-5}{1,-15}{6,-5}{2,-15}{6,-5}{3,-20}{6,-5}{4,-19}{6,-5}{5}",
                HouseType, HouseColor, HouseTrimColor, NumBed, SquareFeet, RoofType, "|");
        }
    }
}
