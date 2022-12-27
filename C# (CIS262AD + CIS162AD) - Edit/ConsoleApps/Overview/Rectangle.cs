using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("\n\tDrawing a Rectangle");
            //base.Draw();
            string retangle = "";
            retangle += "\n\t****************";
            retangle += "\n\t*              *";
            retangle += "\n\t*              *";
            retangle += "\n\t****************";
            Console.WriteLine(retangle);
        }
    }
}
