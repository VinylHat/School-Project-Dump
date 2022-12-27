using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    // Brendan Ellison
    // March 10th, 2021
    // Application for finding where a letter is in the alphabet numericly
    class Alphabet
    {
        private char letter;
        private int numberOfLetter;
        private const string studentName = "Brendan's";
        private const string className = "Alphabet";
        public Alphabet()
        {
            letter = '\0';
            numberOfLetter = 0;
        }
        public Alphabet(char let)
        {
            letter = let;
        }
        //behaviors
        public char Letter
        {
            get { return letter; }
            set { letter = value; }
        }
        public int NumberOfLetter
        {
            get { return numberOfLetter; }
            set { numberOfLetter = value; }
        }
        public string StudentName
        {
            get { return studentName; }
        }
        public string ClassName
        {
            get { return className; }
        }
        private void ConvertLetterToNumber()
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < 26; i++)
            {
                if (letters[i] == letter)
                {
                    numberOfLetter = i + 1;
                }
            }
        }
        public override string ToString()
        {
            ConvertLetterToNumber();
            return String.Format("\n\tThe alphabet character is: {0} and the number is {1}"
                , Letter, NumberOfLetter);
        }
    }
}
