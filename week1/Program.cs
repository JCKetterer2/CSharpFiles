using System;
using Week1.Homework1b;
using week1.week2;
using Week1.Homework2;
using week1.Fundamentals;
using Week1.Homework3;

namespace week1
{
    class Program
    {
        /*
        static Dinosaur dino10;  //not instantiated as a Pterodactyl (for 'as'/null example)
         */

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /*
            Week1Examples();
            Week2Examples();
            */

            //Homework1();            
            Homework2();
            
            //Week3Examples();
            //Week3Dinosaurs();
            //Week4FundamentalsReview();

            Homework3();
        }

        private static void Week1Examples()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Week1 in-class discussion and testing...      ");
            Console.WriteLine("----------------------------------------------");    

            //Use default constructor, creating copy (instance) of Vehicle class
            Vehicle vehicle = new Vehicle();

            vehicle.Color = "Blue";
            
            vehicle.WheelType = "Chrome";
            Console.WriteLine(vehicle.WheelType);

            vehicle.OpenDoor();
            vehicle.CloseWindow();

            vehicle.MoveForward();

            //Instance with parameter constructor
            Vehicle vehicle2 = new Vehicle("Chevy");

            //example of inheritance (car is child class of vehicle parent)
            Car myCar = new Car();
            myCar.Color = "Green";
            myCar.OpenDoor();
            myCar.CloseWindow();
        }

        private static void Week2Examples()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Week2 in-class discussion and testing...      ");
            Console.WriteLine("----------------------------------------------");    

            ReferenceTypes myReferenceType = new ReferenceTypes();
            myReferenceType.JoiningStrings();

            NumericTypes myNumericType = new NumericTypes();
            myNumericType.SpecialValues();

            ValueTypesContinues myValueTypesContinue = new ValueTypesContinues();
            myValueTypesContinue.EnumSample();

            String myTestName1, myTestName2;
            myValueTypesContinue.OutSample("John Doe", out myTestName1, out myTestName2);
            Console.WriteLine(myTestName1 + ' ' + myTestName2);            
        }

        private static void Homework1()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Homework1 bicycle output begins here");
            Console.WriteLine("------------------------------------");

            Bicycle myBicycle = new Bicycle();
            myBicycle.MoveForward();
            myBicycle.NumofGears = 10;
            myBicycle.HandlebarType = "Bullhorn handlebars";
            Console.WriteLine(myBicycle.HandlebarType);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Homework1b bicycle in-class output begins here");
            Console.WriteLine("----------------------------------------------");
            Bicycle1b myBicycle1b = new Bicycle1b();
            MountainBike myMountainBike = new MountainBike();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Homework1b bicycle in-class output2 updates begin here");
            Console.WriteLine("------------------------------------------------------");

            Bicycle1b myBike = new Bicycle1b("BMX");
            MountainBike myMountain = new MountainBike();

            DownHillBike myDownhillBike = new DownHillBike();

            Console.WriteLine(myBike.WheelSpokes);
            Console.WriteLine(myMountain.WheelSpokes);

            Console.WriteLine(myDownhillBike.WheelSpokes);

            myMountain.MyMountainColor();
            myDownhillBike.MyMountainColor();            
        }                

        private static void Homework2()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Homework2 output begins here........");
            Console.WriteLine("------------------------------------");            

            Console.WriteLine();

            Console.WriteLine("Enter grade, noting valid values are:");
            Console.WriteLine("(E)xcellent, (V)ery Good, (G)ood, (A)verage, and (F)ail");
            
            string userGradeInputString = Console.ReadLine().ToUpper();

            while (userGradeInputString.Length != 1)
            {
               Console.WriteLine("Try again.. You must enter ONE character:");
               userGradeInputString = Console.ReadLine().ToUpper();
            }

            char userGradeChar =  Convert.ToChar(userGradeInputString);

            //demonstrate accepting user input and using case statement to evaluate entry
            DetermineGradeDescription myGrade = new DetermineGradeDescription();

            Console.WriteLine("The value you entered equates to: " + myGrade.EvaluateGrade(userGradeChar));

            Console.WriteLine();
            Console.WriteLine("The first TEN natural numbers are:");

            //demonstrate the use of a FOR loop to iterate through and display integer values
            CountToTen myCount = new CountToTen();
            myCount.CountViaForLoop();

            Console.WriteLine();
        }

        private static void Week3Examples()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Week3 in-class discussion and testing...      ");
            Console.WriteLine("----------------------------------------------");             

            AdditonalExamples ae = new AdditonalExamples();
            //ae.CoalescingExample();
            //bool first, second, third, fourth;
            //first = ae.UseUmbrella(true, false, true);
            //second = ae.UseUmbrella(true, true, true);
            //third = ae.UseUmbrella(false, false, false);
            //fourth = ae.UseUmbrella(false, true, false);

            Console.WriteLine(ae.UseUmbrella(true, false, true));
            Console.WriteLine(ae.UseUmbrella(true, true, true));
            Console.WriteLine(ae.UseUmbrella(false, false, false));
            Console.WriteLine(ae.UseUmbrella(false, true, false));

            Statements myStatements = new Statements();
            myStatements.IfStatementBasicExample(10, 12);
            myStatements.IfStatementChainExample("Turkey");
            myStatements.SwitchStatemntExample("Friday");
            myStatements.ForEachLoopExample();
        }        

        private static void Week3Dinosaurs()
        {
            //Dinosaur examples (week3 topics continued)
            Dinosaur dino1 = new Dinosaur();
            dino1.Size = 10;
            dino1.Eat();  //Dinosaur Eat

            TRex tRex = new TRex();
            tRex.Size = 201;
            tRex.Eat();   //TRex Eat

            Dinosaur dino2 = new TRex();        //Upcasting (implicit)
            dino2.Eat();  //TRex Eat

            Dinosaur dino3 = new Pterodactyl(); //Upcasting (implicit)
            dino3.Eat();  //Pterodactyl Eat

            Dinosaur dino4 = new Dinosaur();    //Downcasting (explicit)
            dino4 = (TRex)tRex;
            dino4.Eat();  //TRex Eat


            /*
            Console.WriteLine("--------------------------------");
            Console.WriteLine("..........'as' example..........");
            Console.WriteLine("--------------------------------");
            //gives -- Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object.
            //basically, trying to test if dino10 is a Pterodactyl.  It isn't, so returns as null
            Dinosaur dino6 = dino10 as Pterodactyl;
            dino6.Sleep();
             */

            Console.WriteLine("--------------------------------");
            Console.WriteLine("...array and 'is' example.......");
            Console.WriteLine("--------------------------------");
            Dinosaur[] dinoArray = {dino1, tRex, dino2, dino3};

            foreach (Dinosaur item in dinoArray)
            {
                if(item is TRex)
                {
                    item.Eat();
                }

                if(item is Pterodactyl)
                {
                    item.Sleep();
                }
            }



            /*            
            Console.WriteLine(tRex.Size);

            Dinosaur.Raptor dino2 = new Dinosaur.Raptor();
            dino2.Skin = true;
            dino2.Eat();

            //call default constructor with object initializers (optional parameters, default values)
            Square yourSquare = new Square {Length = 5, Height =5, Color = "Blue"};
            Console.WriteLine("yourSquare Color is " + yourSquare.Color);
             */


            //deconstructor pattern call
            /*
                https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct
                https://stackoverflow.com/questions/40906305/c-sharp-7-0-deconstructor
             */
            /*
            Square mySquare = new Square(3, 3);
            var (length, height) = mySquare;

            //the following 2 lines are interchageable with the above "var" line, same result
            //int l, w;
            //mySquare.Deconstruct(out l, out w);
            
            Console.WriteLine(mySquare.Length);
            Console.WriteLine(length);            
             */
        }

        private static void Week4FundamentalsReview()
        {
            //Fundamentals
            /*
              example of calling a static class and its static method, noting
              that we do not need to instantiate an instance of the class to use it
            */
            Console.WriteLine(Utility.AddTwoNumbers(7,6));


            //the square has access to the abstract class Shape's properties (ie: square.Sides)
            Square square = new Square(5,5);
            square.Sides = 100;
            Console.WriteLine(square.Area());


            //Generics example
            Dinosaur dino1G = new Dinosaur();
            Dinosaur dino2G = new Dinosaur();
            Dinosaur dino3G = new Dinosaur();
            TRex tRexG      = new TRex();
            GenericsList<Dinosaur> dinoList = new GenericsList<Dinosaur>();
            dinoList.Add(dino1G);
            dinoList.Add(dino2G);
            dinoList.Add(dino3G);
            dinoList.Add(tRexG);


            //Indexers
            IndexerSample indexSample = new IndexerSample();
            
            for (int i = 0; i < indexSample.Length; i++)
            {
                Console.WriteLine(indexSample[i]);
            }
        }

        private static void Homework3()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Homework3 output begins here........");
            Console.WriteLine("------------------------------------");            

            //Bicycle with default constructor
            BicycleHW3 myBike3a = new BicycleHW3();
            myBike3a.Seat = "saddle";
            Console.WriteLine("My bike has a " + myBike3a.Seat + " seat type.");

            Console.WriteLine();

            //Bicyle with constructor using a parameter
            BicycleHW3 myBike3b = new BicycleHW3("bullhorn");
            Console.WriteLine("My bike has " + myBike3b.HandlebarType + " handlebars.");           
        }
    }
}
