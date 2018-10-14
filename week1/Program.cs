using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Week1.Homework1b;
using week1.week2;
using Week1.Homework2;
using week1.Fundamentals;
using Week1.Homework3;
using week1.Homework6;
using week1.Homework7;
using week1.Advanced;
using week1.FINAL;

namespace week1
{
    class Program
    {
        /*
        static Dinosaur dino10;  //not instantiated as a Pterodactyl (for 'as'/null example)
         */

        //Delegate example (Advanced - declaring a delegate variable)
        public delegate void TryOn(string type);
        public delegate void Fly(string type);

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /*
            Week1Examples();
            Week2Examples();
            */

            //Homework1();            
            //Homework2();

            //Week3Examples();
            //Week3Dinosaurs();
            //Week4FundamentalsReview();

            //Homework3();

            //DelegateSample();
            //MultiDelegateSample();
            //EventSample();

            //LambdaSample();

            //ExceptionSample();
            //CollectionSample();

            //ThreadingSample();
            //ThreadingSample2();
            //ThreadingReturnSample();

            //SimpleTaskExample();
            //MyAsyncExample();
            //MyLinqExample();

            //Note: HW4 is within DesignPatterns Project/Solution

            //Delegate example for Homework5 (See Advanced folder XWing.cs)
            //DelegateHW5();

            //Exception Handling example for Homework6
            //ExceptionHandlingHW6();
            AsyncTestingHW7();

            //Final();
        }

        private static void MyLinqExample()
        {
            string[] names = { "Tom", "Don", "Harry", "Mary", "Jay" };
            string[] moreNames = { "David", "Jack", "Jane", "Jay", "Bob" };

            IEnumerable<string> query = names
            .Where(n => n.Contains("a"))
            .OrderBy(n => n.Length)
            .Select(n => n.ToUpper());

            foreach (string name in query) Console.WriteLine(name);

            //another way to do a similar query as above, but without the lambda expressions
            IEnumerable<string> customerQuery =
            from cust in moreNames
            where cust.Contains("a")
            select cust;

            foreach (string nameM in customerQuery) Console.WriteLine(nameM);
        }

        private async static void MyAsyncExample()    
        {
            //bottles of beer song
            /*
            AsyncUtility myUtility = new AsyncUtility();
            string myWord = await myUtility.BottlesOfBeerSongAsync();
            Console.WriteLine(myWord);
            */

            // API call within AsyncUtility
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
            //
            AsyncUtility myAPI = new AsyncUtility();
            int myNum = await myAPI.AccessTheWebAsync();
            Console.WriteLine(myNum);

        }

        private async static void AsyncTestingHW7()
        {
            AsyncTesting myAsyncTest = new AsyncTesting();
            string myWord = await myAsyncTest.OpeningCrawlAsync();
            Console.WriteLine(myWord);

            // API call within AsyncTesting
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
            //
            AsyncTesting myAPI = new AsyncTesting();
            int myNum = await myAPI.AccessTheWebAsync();
            Console.WriteLine(myNum);

        }

        private static void SimpleTaskExample()
        {
            Thread.CurrentThread.Name = "Main";

            //Create a task and supply a user delegate by using a lambda expression
            Task task = new Task(() => Console.WriteLine("Hello from task."));
            //Define a run with Task
            //Task task = Task.Run(() => Console.WriteLine("Hello from task."));

            //Start the task
            task.Start();
            //Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);  //from MAIN thread
            task.Wait();
        }

        private static void ThreadingSample()
        {
            //Call two existing methods from here with one in a thread and the other without.
            //If not specified, processes run on "main thread".
            //Asynchronous puts processes on other threads so "maint thread" does not get locked.
            //Output is inter-mingled.
            //Notice the method within parenthesis instead of something like this -- new Thread Week3Dinosaurs();
            Thread thread = new Thread(Week3Dinosaurs);
            thread.Start();

            Week1Examples();
        }
        
        private static void ThreadingSample2()
        {
            //Calling constructor with value using Thread two ways
            ThreadingExample myExample = new ThreadingExample();

            //Thread thread = new Thread(() => myExample.SimpleMethod(100));   //lambda expression
            //thread.Start();

            // ...or the older implementation
            Thread secondThread = new Thread(myExample.DifferentMethod);
            secondThread.Start("I see");
        }

        //The callback method must match the signature of the callback delegate
        public static void ResultCallback(int lineCount)
        {
            Console.WriteLine("Independent task printed {0} lines.", lineCount);
        }

        private static void ThreadingReturnSample()
        {
            ThreadWithState tws = new ThreadWithState("This report displays the number {0}.", 42,
                new ExampleCallback(ResultCallback));
            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            Console.WriteLine("Main thread does some work, then waits.");
            t.Join();
            Console.WriteLine("Independent task has completed; main thread ends.");
        }

        private static void CollectionSample()
        {
            CollectionExamples mySample = new CollectionExamples();

            //mySample.MyArrayListExample();
            mySample.MyListExample();
        }

        private static void ExceptionSample()
        {
            ExceptionExamples examples = new ExceptionExamples();
            //examples.MyException();
            //examples.MySecondExample();
            examples.MyThirdExample();
        }

        private static void ExceptionHandlingHW6()
        {
            ArrayListTesting StarWarsMovies = new ArrayListTesting();
            StarWarsMovies.StarWarsArrayList();

            ArrayList movieList = StarWarsMovies.StarWarsArrayList();

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("The Original Star Wars Trilogy consists of:");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < 7; i += 2)
            {
                try
                {
                    Console.WriteLine("\"" + movieList[i] + "\"" + " released in " + movieList[i + 1]);
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Program loop has exceeded the amount of titles in the movie list.  Exiting program...");
                }
                
            }

        }

        //Lambda example
        private static void LambdaSample()
        {
            LambdaExamples myLamb = new LambdaExamples();
            Console.WriteLine(myLamb.MyLambdaOne(5));

            LambdaExamples mySecond = new LambdaExamples(23);
            Console.WriteLine(mySecond.MyLambdaOne(mySecond.MyValue));
        }


        //Delegate example (Advanced)
        private static void DelegateSample()
        {
            Hats myHat = new Hats("Cowboy", 7);
            TryOn theHat = myHat.TryOnHat;
            theHat("I tried on a " + myHat.HatType + "hat that was size " + myHat.HatSize);

            //Another version of the delegate, independent of the above example
            Hats mySecond = new Hats();
        }

        //Multicast Delegate example (Advanced)
        private static void MultiDelegateSample()
        {
            Hats moreHats = new Hats(7);
            TryOn someHats, niceHat, sadHat;

            niceHat = moreHats.FindLuckHat;
            niceHat("Top");

            sadHat = moreHats.FindUglyHat;
            sadHat("Dunce");

            someHats = niceHat + sadHat;
            someHats("Cowboy");
        }

        //Delegate (Homework5)
        private static void DelegateHW5()
        {
            XWing myXWing = new XWing("Rogue Leader", 7);
            Fly theXWing = myXWing.FlyXWing;
            theXWing("I flew with " + myXWing.XWingType + " who was a rank of " + myXWing.XWingRank);
        }

        //Event sample (Advanced)
        private static void EventSample()
        {
            Coats myCoat = new Coats();       //Instantiate the class
            string result = myCoat.MyResult;  //Get result from property
            Console.WriteLine(result);
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

            char userGradeChar = Convert.ToChar(userGradeInputString);

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
            Dinosaur[] dinoArray = { dino1, tRex, dino2, dino3 };

            foreach (Dinosaur item in dinoArray)
            {
                if (item is TRex)
                {
                    item.Eat();
                }

                if (item is Pterodactyl)
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
            Console.WriteLine(Utility.AddTwoNumbers(7, 6));


            //the square has access to the abstract class Shape's properties (ie: square.Sides)
            Square square = new Square(5, 5);
            square.Sides = 100;
            Console.WriteLine(square.Area());


            //Generics example
            Dinosaur dino1G = new Dinosaur();
            Dinosaur dino2G = new Dinosaur();
            Dinosaur dino3G = new Dinosaur();
            TRex tRexG = new TRex();
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

        private static void Final()
        {
            /*
             * Display the WAG welcome, and prompt
             * the user to choose the order type
            */
            WagIntro myWagIntro = new WagIntro();
            string userOrderType = myWagIntro.OrderType();


            /*
             * Display the order form details based on Order Type choice
            */
            OrderForm myOrder = new OrderForm();
            myOrder.UserOrderForm(userOrderType);


            /* 
             * Prompt user for Gadget size
            */
            #region GadgetSize
            GadgetSizeChoice myGadgetSize = new GadgetSizeChoice();
            
            string userGadgetSizeEntered = myGadgetSize.ChooseGadgetSize();

            switch (userGadgetSizeEntered)
            {
                case "S":
                    userGadgetSizeEntered = "Small";
                    break;

                case "M":
                    userGadgetSizeEntered = "Medium";
                    break;

                case "L":
                    userGadgetSizeEntered = "Large";
                    break;
            }
            #endregion


            /*
             * Prompt user to enter number of Gadgets to order
            */
            #region GadgetNumber
            Console.WriteLine();
            Console.WriteLine("Place order for how many " + userGadgetSizeEntered + " Gadgets ? ");
            Console.WriteLine();


            int numUserGadgetsEntered;

            String Result = Console.ReadLine();
            
            while (!Int32.TryParse(Result, out numUserGadgetsEntered))
            {
                Console.WriteLine("Not a valid number, try again.");

                Result = Console.ReadLine();
            }

            if (numUserGadgetsEntered < 0)
            {
                Console.WriteLine("You entered a negative number.  Converting to positive.");
                numUserGadgetsEntered = Math.Abs(numUserGadgetsEntered);
            }
            #endregion


            /*
             * Prompt user for Gadget power source, and display order details
            */
            #region PowerSourceAndDetails
            string powerSelection = "";

            OrderCheckOut myCheckOut = new OrderCheckOut();

            switch (userGadgetSizeEntered)
            {
                case "Small":
                    myCheckOut.DisplayOrder(userGadgetSizeEntered, "B");
                    powerSelection = "B";
                    break;

                case "Medium":
                    PowerSource selectedPowerSourceMedium = new PowerSource();
                    string powerMedium = selectedPowerSourceMedium.UserPowerSourceMedium();
                    powerSelection = powerMedium;

                    myCheckOut.DisplayOrder(userGadgetSizeEntered, powerMedium);
                    break;

                case "Large":
                    PowerSource selectedPowerSourceLarge = new PowerSource();
                    string powerLarge = selectedPowerSourceLarge.UserPowerSourceLarge();
                    powerSelection = powerLarge;

                    myCheckOut.DisplayOrder(userGadgetSizeEntered, powerLarge);
                    break;
            }
            #endregion

            #region UnsuedInterfaceCode
            /*
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            WidgetSmall mySmallWidget1 = new WidgetSmall();
            mySmallWidget1.DisplaySmallWidgetComponents();     //this works because WidgetSmall.cs automatically inherits from the abstract Widget.cs
            Console.WriteLine();
            Console.WriteLine();

            WidgetMedium myMediumWidget1 = new WidgetMedium();
            myMediumWidget1.DisplayMediumWidgetComponents();   //this works because WidgetMedium.cs automatically inherits from the abstract Widget.cs
            Console.WriteLine();
            Console.WriteLine();

            WidgetLarge myLargeWidget1 = new WidgetLarge();
            myLargeWidget1.DisplayLargeWidgetComponents();     //this works because WidgetLarge.cs automatically inherits from the abstract Widget.cs
            Console.WriteLine();
            Console.WriteLine();
            */
            #endregion


            Console.WriteLine(" ");
            Console.WriteLine(" ");

            #region OrderCart            
            OrderCart myCurrentOrder = new OrderCart();
            myCurrentOrder.MyOrderCart(numUserGadgetsEntered, powerSelection);

            DisplayPricing myPriceDisplay = new DisplayPricing();
            myPriceDisplay.DisplayCurrentOrder(userGadgetSizeEntered, numUserGadgetsEntered, powerSelection);
            #endregion


            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue with another order, or Q + ENTER to quit...");
            Console.WriteLine();

            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Final();
            }
        }
    }
}