using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("\n\tDrawing a Circle");
            //base.Draw();
            string circle = "";
            circle += "\n\t      ***      ";
            circle += "\n\t   ***   ***   ";
            circle += "\n\t***         ***";
            circle += "\n\t***         ***";
            circle += "\n\t   ***   ***   ";
            circle += "\n\t      ***      ";
            Console.WriteLine(circle);
        }
    }
}
