using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    // Brendan Ellison
    // 4/2/2021
    class MinMax
    {
        private int[] numbers;
        private const string studentName = "Brendan's";
        private const string className = "Min Max";
        public MinMax (int[] num)
        {
            numbers = num;
        }
        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public string ClassName
        {
            get { return className; }
        }
        public string StudentName
        {
            get { return studentName; }
        }
        private string MinMaxFinder()
        {
            int min = 10000;
            int max = 0;
            int sum = 0;
            int average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                sum += numbers[i];
                average = sum / numbers.Length;
            }

            string message = "\n\tThe average of these numbers is:\t" + average.ToString() + 
                "\n\tWith a minimum of:\t" + min.ToString() + 
                "\n\tAnd a maximum of:\t" + max.ToString();
            return message;
        }
        public override string ToString()
        {
            return MinMaxFinder();
        }
    }
}
