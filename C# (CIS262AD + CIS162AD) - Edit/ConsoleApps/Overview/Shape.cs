using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Shape
    {
        public const string STUDENT_NAME = "Brendan's";
        public const string CLASS_NAME = "Polymotphism";
        public string StudentName
        {
            get { return STUDENT_NAME; }
        }
        public string ClassName
        {
            get { return CLASS_NAME; }
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("\n\tPerforming base class drawing tasks");
        }
    }
}
