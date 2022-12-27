using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Brendan Ellison
             *  May 17th, 2021
             *  
             *  The app will take data, put it in a class,
             *  and display the data as object in the correct order with the lable
             */

            FinalExam fe1 = new FinalExam("Ford","Mustang",2016,"Red",35059);

            FinalExam fe2 = new FinalExam("Chevy", "Camaro", 2016, "Blue", 36425);
            //I was lazy so I used the constructor twice

            FinalExam fe3 = new FinalExam();
            fe3.Make = "Dodge";
            fe3.Model = "Charger";
            fe3.Year = 2016;
            fe3.Color = "Yellow";
            fe3.Price = 38295.0;

            Console.WriteLine("\n\tWould you like to add another car?" +
                "\n\t(enter yes, anything else will be assumed as no)");
            string input = Console.ReadLine();
            // Just in case I made it case insensitive
            if (input.ToLower() == @"yes")
            {
                FinalExam fe4 = new FinalExam();

                Console.WriteLine("\n\n\tWho makes your vehicle?");
                fe4.Make = Console.ReadLine();

                Console.WriteLine("\n\tWhat model is your vehicle?");
                fe4.Model = Console.ReadLine();

                Console.WriteLine("\n\tWhat year was your vehicle released?");
                input = Console.ReadLine();
                int.TryParse(input, out int year);
                fe4.Year = year;

                Console.WriteLine("\n\tWhat color is your vehicle?");
                fe4.Color = Console.ReadLine();

                Console.WriteLine("\n\tHow much is your vehicle worth?");
                input = Console.ReadLine();
                double.TryParse(input, out double price);
                fe4.Price = price;

                Console.WriteLine("\n\tThank you for your time");
                Console.WriteLine("\n\n\t{0,-9}{1,-10}{2,-9}{3,-10}{4,-10}", "Make", "Model", "Year", "Color", "Price");
                Console.WriteLine("\n\t------------------------------------------------");
                Console.WriteLine(fe1);
                Console.WriteLine(fe2);
                Console.WriteLine(fe3);
                Console.WriteLine(fe4);
            }
            else
            {
                Console.WriteLine("\n\n\t{0,-9}{1,-10}{2,-9}{3,-10}{4,-10}","Make", "Model","Year","Color","Price");
                Console.WriteLine("\n\t------------------------------------------------");
                Console.WriteLine(fe1);
                Console.WriteLine(fe2);
                Console.WriteLine(fe3);
            }
            Console.ReadKey();
        }
    }
}
