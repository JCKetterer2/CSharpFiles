using System;

namespace week1.week2
{
    public class ValueTypesContinues
    {

        #region Enums

        // Enum declaration with default values
        private enum Positon { Left, Right, Top, Bottom };

        // Enum declaration with defined values
        private enum MovieType { Action = 100, Comedy = 200, Drama = 300 };

        // Enum declaration with mixed defined and non-defined values
        private enum Days { Sun, Mon = 8, Tue = 9, Wed = 10, Thur, Fri, Sat };

        /*
         * Enums are a special type that allows you to specify a group of numeric constants.
         * Converting an enum requires and explicit cast.
         * 
         */
        public void EnumSample()
        {
            Console.WriteLine("Value for days not set is {0}", (int)Days.Thur);
            Console.WriteLine("Favorite type of movie value is {0}", (int)MovieType.Action);
        }

        #endregion

        #region Reference Modifiers using ref and out

        /**
         * To pass a Reference modifier we use the ref keyword
        * **/
        public void RefSample(ref int value)
        {
            int sample = value + 5;
            //Console.WriteLine(sample);
        }
        /**
         *  The out keyword is like ref except that it doesn't need to be assigned before entering a method
         * **/
        public void OutSample(string name, out string firstName, out string lastName)
        {
            int myIndex = name.LastIndexOf(' ');
            firstName = name.Substring(0, myIndex);
            lastName = name.Substring(myIndex + 1);
            //Console.WriteLine(firstName);
            //Console.WriteLine(lastName);
        }

        #endregion

    }

    /**
    * Structs are simular to class files except its considered a value type rather than a reference type
    * **/
    public struct TestStruct
    {
        int testOne;
        int testTwo;
        public TestStruct(int one, int two)
        {
            this.testOne = one;
            this.testTwo = two;
            Console.WriteLine(testOne + testTwo);
        }
    }
}