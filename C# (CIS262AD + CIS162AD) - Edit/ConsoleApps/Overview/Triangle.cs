 using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("\n\tDrawing a Triangle");
            //base.Draw();
            string triangle = "";
            triangle += "\n\t     **";
            triangle += "\n\t   ** *";
            triangle += "\n\t **   *";
            triangle += "\n\t*******";
            Console.WriteLine(triangle);
        }
    }
}
