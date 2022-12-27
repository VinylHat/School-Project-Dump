using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    // Brendan Ellison
    // March 10th, 2021
    // Program to create squares made of characters
    class Stars
    {
        private char characterToDisplay;
        private int numberOfRows;
        private const string studentName = "Brendan's";
        private const string className = "Stars";
        public Stars()
        {
            characterToDisplay = '\0';
            numberOfRows = 0;
        }
        public Stars(char c, int i)
        {
            characterToDisplay = c;
            numberOfRows = i;
        }
        public char CharacterToDisplay
        {
            get { return characterToDisplay; }
            set { characterToDisplay = value; }
        }
        public int NumberOfRows
        {
            get { return numberOfRows; }
            set { numberOfRows = value; }
        }
        public string StudentName
        {
            get { return studentName; }
        }
        public string ClassName
        {
            get { return className; }
        }
        private string BuildGrid()
        {
            string str = "\n\t";
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int i1 = 0; i1 < numberOfRows; i1++)
                {
                    str += (characterToDisplay + " ");
                }
                str += "\n\t";
            }
            return str;
        }
        public override string ToString()
        {
            return BuildGrid();
        }
    }
}
