using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    // Brendan Ellison
    // 3/29/2021
    class ArrayExamples
    {
        private int position;
        private char letter;
        private int number;
        private const string studentName = "Brendan's";
        private const string className = "ArrayExamples";
        
        public ArrayExamples()
        {
            Position = 0;
            Number = 0;
            Letter = '\0';
        }
        public ArrayExamples(int pos, char letr)
        {
            Position = pos;
            Number = 0;
            Letter = letr;
        }
        public ArrayExamples(int pos, int num)
        {
            Position = pos;
            Number = num;
            Letter = '\0';
        }
        public string StudentName
        {
            get { return studentName; }
        }
        public string ClassName
        {
            get { return className; }
        }
        public int Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public char Letter
        {
            get { return letter; }
            set { letter = value; }
        }
        public void BuildCharArray(char[] a)
        {
            a[0] = 'D';
            a[1] = 'a';
            a[2] = 'v';
            a[3] = 'i';
            a[4] = 'd';
        }
        public string DisplayCharArray(char[] a)
        {
            string str1 = "";
            foreach (char letter in a)
            {
                str1 += letter.ToString();
            }
            return str1;
        }
        public void ChangeCharArray(char[] arr)
        {
            arr[Position] = Letter;
        }
        public void BuildIntegerArray(int[] a)
        {
            a[0] = 25;
            a[1] = 30;
            a[2] = 35;
            a[3] = 40;
            a[4] = 50;
        }
        public string DisplayIntegerArray(int[] a)
        {
            string str1 = "";
            foreach (int num in a)
            {
                str1 += "\t" + num.ToString();
            }
            return str1;
        }
        public void ChangeIntegerArray(int[] arr)
        {
            arr[Position] = Number;
        }
        public void SortIntegerArray(int[] arr)
        {
            for (int p = 0; p < arr.Length; p++)
            {
                int t;
                for (int i = 0; i < arr.Length -1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
        }
        public override string ToString()
        {
            return "\n\tThank you for using the ArrayExamples class";
        }
    }
}
