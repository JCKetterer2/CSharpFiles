using System;
using Week1.Homework1b;
using week1.week2;
using Week1.Homework2;
using week1.Fundamentals;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /*
            Week1Examples();
            Week2Examples();

            Homework1();
            */

            Homework2();
            
           //Week3Examples();
             

            
            //Fundamentals
            /*
            Dinosaur dino1 = new Dinosaur();
            dino1.Size = 10;

            TRex tRex = new TRex();
            tRex.Size = 201;
            Console.WriteLine(tRex.Size);

            Dinosaur.Raptor dino2 = new Dinosaur.Raptor();
            dino2.Skin = true;
            dino2.Eat();
             */
            
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

            if(userGradeInputString.Length == 1)
            {
                char userGradeChar =  Convert.ToChar(userGradeInputString);

                //demonstrate accepting user input and using case statement to evaluate entry
                DetermineGradeDescription myGrade = new DetermineGradeDescription();

                Console.WriteLine("The value you entered equates to: " + myGrade.EvaluateGrade(userGradeChar));
            }
            else
            {
                Console.WriteLine("You may only enter one character");
            }


            Console.WriteLine();
            Console.WriteLine("The first TEN natural numbers are:");

            //demonstrate the use of a FOR loop to iterate through and display integer values
            CountToTen myCount = new CountToTen();
            myCount.CountViaForLoop();
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
    }
}
