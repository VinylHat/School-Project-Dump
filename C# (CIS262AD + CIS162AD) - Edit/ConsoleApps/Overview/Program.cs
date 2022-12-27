using System;
using System.IO;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Brendan's Arithmetic Operations\n");
            //Console.Write("\tPlease enter two different numbers\n\tYour first number is:\t");
            //string input = Console.ReadLine();
            //double.TryParse(input, out double num1);
            // I chose to use doubles just to allow a large veriety of numbers

            //Console.Write("\tNow enter your second number:\t");
            //input = Console.ReadLine();
            //double.TryParse(input, out double num2);

            //Chp1Exc6 c1e6 = new Chp1Exc6();

            //c1e6.Num1 = num1;
            //c1e6.Num2 = num2;
            //Console.WriteLine(c1e6);

            //Chp1Exc6 c1e6a = new Chp1Exc6(10, 15); // hard coded
            //Console.WriteLine(c1e6a);

            //System.Console.WriteLine();
            //Namespace.Class.Method(variables);

            // Elements of High Quality Programs - C# (chp6Exc6.cs)
            //Console.Write("\n\tEnter the Height of the person in inches :\t");
            //string input = Console.ReadLine();
            //double.TryParse(input, out double h);
            //Console.Write("\n\tEnter the Weight of the person in pounds :\t");
            //input = Console.ReadLine();
            //double.TryParse(input, out double w);

            // Instantiate the Class (create object)
            //Chp2Exc6 c2e6 = new Chp2Exc6(h, w);
            //Console.WriteLine(c2e6);

            //Console.Write("\n\tEnter the Height of the person in inches :\t");
            //input = Console.ReadLine();
            //double.TryParse(input, out double h1);
            //Console.Write("\n\tEnter the Weight of the person in pounds :\t");
            //input = Console.ReadLine();
            //double.TryParse(input, out double w1);

            // New object with default Constructor
            //Chp2Exc6 c2e61 = new Chp2Exc6();
            //c2e61.Height = h1;
            //c2e61.Weight = w1;
            //Console.WriteLine(c2e61);

            //Chp3Exc2
            //Console.WriteLine("\n\tPlease enter your first number");
            //string input = Console.ReadLine();
            //double.TryParse(input, out double a);
            //Console.WriteLine("\n\tNow please enter your second number");
            //input = Console.ReadLine();
            //double.TryParse(input, out double b);

            //Chp3Exc2 c3e21 = new Chp3Exc2();
            //c3e21.X = a;
            //c3e21.Y = b;
            //Console.WriteLine(c3e21);

            //Chp3Exc2 c3e2 = new Chp3Exc2(10, 15);
            //Console.WriteLine(c3e2);

            //This code will run CollegeAdmissions.cs
            //Instantiate the CollegeAdmissions class
            //CollegeAdmissions ca1 = new CollegeAdmissions();
            //ca1.TestScore = 95;
            //ca1.ClassRank = 5;
            //Console.WriteLine(ca1);

            //CollegeAdmissions ca2 = new CollegeAdmissions(93, 3);
            //Console.WriteLine(ca2);

            //Console.WriteLine(new CollegeAdmissions(90, 75));
            //Console.WriteLine(new CollegeAdmissions(90, 50));
            //Console.WriteLine(new CollegeAdmissions(90, 25));

            //Console.WriteLine(new CollegeAdmissions(80, 75));
            //Console.WriteLine(new CollegeAdmissions(80, 50));
            //Console.WriteLine(new CollegeAdmissions(80, 25));

            //Console.WriteLine(new CollegeAdmissions(70, 75));
            //Console.WriteLine(new CollegeAdmissions(70, 50));
            //Console.WriteLine(new CollegeAdmissions(70, 25));

            //Console.WriteLine(new CollegeAdmissions(60, 75));
            //Console.WriteLine(new CollegeAdmissions(60, 50));
            //Console.WriteLine(new CollegeAdmissions(60, 25));

            //Console.WriteLine(new CollegeAdmissions(50, 75));
            //Console.WriteLine(new CollegeAdmissions(50, 50));
            //Console.WriteLine(new CollegeAdmissions(50, 25));

            //string menuMessage = "\n\tChoose from the menu:" +
            //    "\n\n\t1. Calculate area of a circle" +
            //    "\n\t2. Calculate area of a rectangle" +
            //    "\n\n\tEnter your choice 1 or 2 (0 will close the program)";
            //Console.WriteLine(menuMessage);
            //string input = Console.ReadLine();
            //int.TryParse(input, out int choice);
            //string areaMessage = "";
            //double area = 0.0;
            //switch (choice)
            //{
            //    case 0:

            //        break;
            //    case 1:
            //        area = 0;
            //        areaMessage = "\n\tArea of the Circle is:\t{0:N2}",area;
            //        break;
            //    case 2:
            //        area = 0;
            //        areaMessage = "\n\tArea of the Rectangle is:\t{0:N2}",area;
            //        break;
            //    default:
            //        areaMessage = "invalid input"; 
            //        break;
            //}
            //Console.WriteLine(areaMessage);

            //Making Decisions (Grades.cs)
            //default constructor using behaviors
            //Grades g = new Grades();
            //add this line of code to your Program.cs to test the name and class behaviors
            //CollegeAdmissions ca = new CollegeAdmissions();
            //Console.WriteLine(String.Format("\n\tWelcome to {0} {1} class", ca.Name, ca.ClassName));
            //bool flag = true;
            //do
            //{
            //    Console.WriteLine("\n\tEnter the grade and class rank below.\tIf you want to quit enter a 0.");
            //    Console.Write("\n\n\tGrade on entrance exam:\t");
            //    string input = Console.ReadLine();
            //    int.TryParse(input, out int grade);

            //    if (grade != 0)
            //    {
            //        Console.Write("\n\tClass rank:\t");
            //        input = Console.ReadLine();
            //        int.TryParse(input, out int rank);
            //        ca.TestScore = grade;
            //        ca.ClassRank = rank;
            //        Console.WriteLine(ca);
            //    }
            //    else
            //    {
            //        flag = false;
            //    }
            //} while (flag);
            //Console.WriteLine("\n\n\tThank you for using the Collage Admissions program");

            //g.Score = 95.5;
            //Console.WriteLine(g);

            //g.Score = 89.9;
            //Console.WriteLine(g);

            //g.Score = 70.1;
            //Console.WriteLine(g);

            ////argument constructor
            //Grades g1 = new Grades(65);
            //Console.WriteLine(g1);

            ////argument constructor using new
            //Console.WriteLine(new Grades(54));

            //Instantiate the object for Alphabet with the default constructor
            //Alphabet a = new Alphabet();
            //Console.WriteLine("\n\tWelcome to {0} {1} class application.", a.StudentName, a.ClassName);
            //a.Letter = 'g';
            //Console.WriteLine(a);

            //Alphabet a1 = new Alphabet('j');
            //Console.WriteLine(a1);

            //Console.WriteLine(new Alphabet('r'));

            //Stars s = new Stars();
            //Console.WriteLine("\n\tWelcome to {0} {1} class application.", s.StudentName, s.ClassName);
            //s.CharacterToDisplay = '*';
            //s.NumberOfRows = 10;
            //Console.WriteLine(s);

            //Stars s1 = new Stars('>', 15);
            //Console.WriteLine(s1);

            //Console.WriteLine(new Stars('&', 20));

            //Arrays (ArrayExamples.cs)
            //Use the default constructor
            //ArrayExamples ae = new ArrayExamples();
            //Console.WriteLine("\n\tWelcome to {0} {1} class application.", ae.StudentName, ae.ClassName);
            ////Declare a character array of 5 elements
            //char[] arrayChar = new char[5];
            //ae.BuildCharArray(arrayChar);
            //Console.WriteLine("\n\t" + ae.DisplayCharArray(arrayChar));

            ////Change the fourth letter to a j
            //ae.Position = 3;
            //ae.Letter = 'j';
            //ae.ChangeCharArray(arrayChar);
            //Console.WriteLine("\n\t" + ae.DisplayCharArray(arrayChar));

            ////Declare an integer array of 5 elements
            //int[] arrayInteger = new int[5];
            //ae.BuildIntegerArray(arrayInteger);
            //Console.WriteLine(ae.DisplayIntegerArray(arrayInteger));
            //ae.Position = 2;
            //ae.Number = 200;
            //ae.ChangeIntegerArray(arrayInteger);
            //Console.WriteLine(ae.DisplayIntegerArray(arrayInteger));

            //ae.SortIntegerArray(arrayInteger);
            //Console.WriteLine(ae.DisplayIntegerArray(arrayInteger));

            ////Use the first two argument constructor
            //ArrayExamples ae2 = new ArrayExamples(3, 'S');
            //ae2.ChangeCharArray(arrayChar);
            //Console.WriteLine("\n\t" + ae2.DisplayCharArray(arrayChar));

            ////Use the second two argument constructor
            //ArrayExamples ae3 = new ArrayExamples(4, 300);
            //ae3.ChangeIntegerArray(arrayInteger);
            //Console.WriteLine(ae3.DisplayIntegerArray(arrayInteger));

            //This code will run ParallelArrays.cs
            //string[] fName = new string[]
            // { "David", "Aaron", "Michael", "Jonathan", "Colm" };
            //string[] lName = new string[]
            // { "Smith", "Johnson", "Jones", "Goldfield", "Hines" };
            //int[] id = new int[]
            // { 12345, 23456, 34567, 45678, 56789 };
            //ParallelArrays pa = new ParallelArrays(fName, lName, id);
            //Console.WriteLine(pa);

            //this code will run minmax.cs
            //int[] minmax = new int[] { 20, 13, 45, 26, 33, 21, 15, 56, 61, 15 };
            //MinMax mm = new MinMax(minmax);
            //Console.WriteLine("\n\tWelcome to {0} {1} program",mm.StudentName, mm.ClassName);
            //Console.WriteLine(mm);

            //FileHandling fh = new FileHandling("NewFile.dat");
            ////Using default constructor
            ////FileHandling fh = new FileHandling();
            ////fh.FilePath = "NewFile.dat";
            //WriteLine("\n\tWelcome to {0} {1} class application.", fh.StudentName, fh.ClassName);

            ////delete the file if it already exists
            ////fh.DeleteFile();

            ////create the file
            //fh.CreateFile();


            ////close the file
            //fh.CloseFileStream();

            ////add text to the file and close it (two iterations)
            //fh.OpenFileWrite();
            //fh.AddTextToFile("\n\tThis is the first line in my file.");
            //fh.CloseStreamWriter();
            //fh.OpenFileWrite();
            //fh.AddTextToFile("\n\tThis is the second line in my file.");
            //fh.CloseStreamWriter();

            ////Open the file and read it back into a local string variable.
            //string fileContents = fh.ReadTextFromFile();
            //fh.CloseFileStream();
            ////display the contents of the file on the console
            //WriteLine(fileContents);
            //WriteLine(fh);

            //fh.DeleteFile();
            // This just breaks everything
            // I honestly dont know why

            //int[] sortArray = new int[] { 20, 13, 45, 26, 33, 21, 15, 56, 61, 15 };

            //string str = "";
            //for (int j = 0; j < sortArray.Length - 1; j++)
            //{
            //    for (int i = j + 1; i < sortArray.Length; i++)
            //    {
            //        if (sortArray[j] < sortArray[i])
            //        {
            //            int input = sortArray[i];
            //            sortArray[i] = sortArray[j];
            //            sortArray[j] = input;
            //        }
            //    }
            //}
            //for (int i = 0; i < sortArray.Length; i++)
            //{
            //    str += sortArray[i] + "\t";
            //}
            //WriteLine(str);

            //string str = "\n\t";
            //string[] strArray =
            //    {"Brendan", "Kyle", "David", "Berry", "Sky", "Snowball", "Yellow",
            //    "Matt", "Jeff", "Tony", "Noah", "Connor", "Casey", "Rebecca", "Anakin" };
            //// I figured names are probably a more real example, the weird ones are my birds names.
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    if (i == 5 || i == 10 || i == 15)
            //    {
            //        str += strArray[i] + "\n\t";
            //    }
            //    else
            //    {
            //        str += strArray[i] + ",\t";
            //    }
            //}
            //WriteLine(str);
            //str = "\n\t";

            //// I am pretty sure this is what you ment but I wanted to try it.
            //// Nothing surprising, more of just wanted to know if it would be "that" easy
            //for (int j = 0; j < strArray.Length - 1; j++)
            //{
            //    for (int i = j + 1; i < strArray.Length; i++)
            //    {
            //        if (strArray[j].Length < strArray[i].Length)
            //        {
            //            string input = strArray[i];
            //            strArray[i] = strArray[j];
            //            strArray[j] = input;
            //        }
            //    }
            //}
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    if (i == 5 || i == 10 || i == 15)
            //    {
            //        str += strArray[i] + "\n\t";
            //    }
            //    else
            //    {
            //        str += strArray[i] + ",\t";
            //    }
            //}
            //WriteLine(str);
            //str = "\n\t";


            //Array.Sort<string>(strArray);
            //// This is also probably not what you wanted
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    if (i == 5 || i == 10 || i == 15)
            //    {
            //        str += strArray[i] + "\n\t";
            //    }
            //    else
            //    {
            //        str += strArray[i] + ",\t";
            //    }
            //}
            //WriteLine(str);
            //str = "\n\t";

            //int[,] dimArray =  
            //{
            //      {20,13,45,26},
            //      {33,21,15,56}
            //};
            //int[,] dimArray2 = new int[3, 4];
            //WriteLine("\n\t" + dimArray[0, 0]);  //first row and the first column
            //WriteLine("\n\t" + dimArray[0, 1]);  //first row and the second column
            //WriteLine("\n\t" + dimArray[1, 0]);  //second row and the first column
            //WriteLine();
            //for (int i = 0; i < dimArray.GetLength(1); i++)
            //{
            //    Write("\t" + dimArray[0, i]);  //display the columns in the first row
            //};

            //for (int i = 0; i < dimArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dimArray.GetLength(1); j++)
            //    {
            //        Write("\t" + dimArray[i , j]);
            //    }
            //    WriteLine();
            //};

            //int k = 0;
            //for (int i = 0; i < dimArray2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dimArray2.GetLength(1); j++)
            //    {
            //        dimArray2[i, j] = k++;
            //    }
            //};
            //WriteLine();
            //for (int i = 0; i < dimArray2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dimArray2.GetLength(1); j++)
            //    {
            //        Write("\t" + dimArray2[i, j]);
            //    }
            //    WriteLine();
            //};


            //Array2D.cs
            //double[,] pricePerDaysAndAgeTable =
            //{
            //    { 30.00, 60.00, 88.00, 115.00, 140.00},
            //    { 26.00, 52.00, 70.00, 96.00, 120.00},
            //    { 24.00, 40.00, 60.00, 75.00, 88.00},
            //    { 22.00, 40.00, 60.00, 75.00, 88.00},
            //    { 20.00, 35.00, 50.00, 66.00, 84.00}
            //};
            //Write("\n\tEnter the age of the child in years (0 for less than one year):\t");
            //int numYears = Convert.ToInt32(ReadLine());
            //Write("\n\tEnter the number of days per week (1 - 5):\t");
            //int numDays = Convert.ToInt32(ReadLine());
            //Array2D a2d1 = new Array2D(numDays, numYears, pricePerDaysAndAgeTable);
            //WriteLine(a2d1);

            //caller
            //Recursion
            //int rec = recursion(10);

            //This program is to run CalculateAge.cs
            //Write("\n\tEnter your birth month:\t");
            //double birthMonth = Convert.ToDouble(Console.ReadLine());
            //Write("\n\tEnter your birth year:\t");
            //double birthYear = Convert.ToDouble(Console.ReadLine());
            //CalculateAge ca = new CalculateAge(birthMonth, birthYear);
            //WriteLine(ca);

            //Employee emp = new Employee();
            //emp.FirstName = "David";
            //emp.MiddleName = "L";
            //emp.LastName = "Smith";
            //WriteLine(emp);

            //Employee emp1 = new Employee("John", "Alan", "Bateman");
            //WriteLine(emp1);

            //Employee emp2 = new Employee("Sam", "J", "Johnson", "salary", "EM123", 'm');
            //WriteLine(emp2);

            //Employee emp3 = new Employee("Jane", "R", "Thompson", "salary", "EM124", 'f');
            //emp3.City = "Los Angeles";
            //emp3.State = "California";
            //emp3.Street = "413 West Side Street";
            //emp3.ZipCode = "90201";
            //WriteLine(emp3);

            //Employee emp4 = new Employee("Sam", "J", "Johnson", "salary", "EM123", 'm', "(602) 942-5555", "userSamJ@pvcc.com");
            //emp4.City = "Los Angeles";
            //emp4.State = "California";
            //emp4.Street = "413 West Side Street";
            //emp4.ZipCode = "90201";
            //WriteLine(emp4);

            //EmployeePay emp5 = new EmployeePay("Jane", "R", "Thompson", "salary", "EM124", 'f', "(623) 480-1236", "jrthompson@tx.com");
            //emp5.City = "Los Angelas";
            //emp5.State = "California";
            //emp5.Street = "413 West Side Street";
            //emp5.ZipCode = "90201";
            //emp5.Wage = 2000;
            //WriteLine(emp5);

            //EmployeePay emp6 = new EmployeePay("Janis", "A", "Johnson", "hourly", "EM126", 'f', "(623) 480-1237", "cajohnson@tx.com");
            //emp6.Street = "5005 West Glenn Drive";
            //emp6.City = "Glendale";
            //emp6.State = "AZ";
            //emp6.ZipCode = "85302";
            //emp6.Wage = 17.0;
            //emp6.Hours = 41;
            //WriteLine(emp6);

            //EmployeePay emp7 = new EmployeePay("Joann", "G", "Melvin", "sales", "EM128", 'f', "(623) 480-1238", "jgmelvin@tx.com");
            //emp7.Street = "2001 North 2nd Street";
            //emp7.City = "Tucson";
            //emp7.State = "AZ";
            //emp7.ZipCode = "85101";
            //emp7.Sales = 2050.00;
            //emp7.Wage = 1500;
            //emp7.Rate = .05;
            //WriteLine(emp7);

            //Example of polymorphism
            //Shape s = new Shape();
            //Console.WriteLine("\n\tWelcome to {0} {1} class application.",s.StudentName,s.ClassName);
            //// A Rectangle, Triangle and Circle
            //// can all be used whereever a Shape is expected. No cast is
            //// required because an implicit conversion exists from a derived
            //// class to its base class.
            //var shapes = new List<Shape>
            //{
            //    new Rectangle(),
            //    new Triangle(),
            //    new Circle()
            //};
            //// The virtual method Draw is
            //// invoked on each of the derived classes, not the base class.
            //foreach (var shape in shapes)
            //{
            //    shape.Draw();
            //}


            //Create a Program.cs of my own
            //Needs heading (name, date, purpose)
            //needs a class (FinalExam.cs)
            //call a ToString() method

            FinalExample fe1 = new FinalExample();
            fe1.HouseType = "Ranch";
            fe1.HouseColor = "Beige";
            fe1.HouseTrimColor = "Blue";
            fe1.NumBed = 3;
            fe1.NumBath = 3;
            fe1.SquareFeet = 2450;
            fe1.RoofType = "Tile";

            FinalExample fe2 = new FinalExample("Two Story", "Brown", "White", 5, 3, 3500, "Asphalt");
            string heading = string.Format("\n\t{0,-14}{6,-5}{1,-15}{6,-5}{2,-15}{6,-5}{3,-20}{6,-5}{4,-19}{6,-5}{5}",
                "Type", "Base Color", "Trim Color", "Number Bedrooms", "Square Footage", "Roof Type", "|");
            string spacer = "\t---------------------------------------------------------------------------------------------------------------------";

            SetWindowSize(130,20);
            Console.WriteLine(heading);
            Console.WriteLine(spacer);
            Console.WriteLine(fe1);
            Console.WriteLine(fe2);

            //string heading2 = string.Format("\n\t{0,-20}-{1,-20}-{2,-20}-{3,-20}-{4,-20}-{5,-20}",
                //"Type", "Base Color", "Trim Color", "Number Bedrooms", "Square Footage", "Roof Type");
            //Console.WriteLine(heading2);
            //Console.WriteLine(fe1);
            //Console.WriteLine(fe2);

            WriteLine("\n\tEnd of Job.");
            ReadKey();
        }
        //Callees
        //int recursion(int x)
        //{
        //    int y = x + 1;
        //    if (y == 100)
        //        return y;
        //    recursion(y);
        //}
    }
}
