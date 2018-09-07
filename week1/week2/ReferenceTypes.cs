using System;
using System.Text;

namespace week1.week2
{
    public class ReferenceTypes
    {

        private string _testString = "Test String";
        private string _testString2 = "is awesome";

        #region Joining Strings

        public void JoiningStrings()
        {
            string secondTest = "written test";
            Console.WriteLine("This is a " + _testString); // This is a Test String
            Console.WriteLine(_testString + secondTest);  //Test Stringwritten test
        }

        public void JoinStringsWithBuilder()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(_testString)
            .Append(_testString2)
            .Append(" and super cool.");

            // In order to use the builder, you have to call the ToString method so it converts.
            Console.WriteLine(builder.ToString());
        }

        #endregion

        #region Placeholders and compare strings
        public void PlaceHolderString()
        {
            string sampleFour = "forth";
            Console.WriteLine("This is a third {0}", _testString);             // This is a third Test String
            Console.WriteLine("This {0} is the {1}", _testString, sampleFour);
        }

        public void CompareStrings()
        {
            string ab = "Test String";
            Console.WriteLine(_testString == ab);
        }

        #endregion

        #region Char
        public void CharType()
        {
            char ab = 'A'; //Character
            char de = 'B'; //Character
            char copyWriteSymbol = '\u00A9'; // Unicode
            char fg = '\x0058'; // Hexidecimal
            char hi = (char)88; // Explicit Case from int.
            Console.WriteLine(ab == de); // false
            Console.WriteLine("The copywrite symbol looks like {0}", copyWriteSymbol);
        }

        #endregion

        #region Arrays

        /**
         * Arrays represent a fixed number of variables or elements of a type.
         * Arrays can be made up of Strings or Value types
         * They start with an index of 0. If you exceed the size of an array, you will trigger
         * an IndexOutOfRangeException. Their can be multidimensional arrays.
         * **/

        public void ArraySingleSample()
        {
            string[] cars = new string[3];
            cars[0] = "camaro";
            cars[1] = "mustang";
            cars[2] = "chevelle";
            // or
            string[] names = { "Tom", "Roger", "Matt" };

            Console.WriteLine(cars[1]);
            Console.WriteLine(names[0]);
        }

        public void ArrayRectanglurSample()
        {
            int[,] sampleInt = new int[2, 2];
            sampleInt[0, 0] = 5;
            sampleInt[0, 1] = 10;
            sampleInt[1, 0] = 2;
            sampleInt[1, 1] = 4;

            Console.WriteLine(sampleInt[1, 0]);
        }

        public void ArrayJaggedSample()
        {
            int[][] sampleJagged = new int[2][];
            sampleJagged[0] = new int[] { 2, 3, 4 }; //int[3]
            sampleJagged[1] = new int[] { 5, 6 };

            // or

            int[][] secondSample = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] { 6, 7, 8, 9 },
                new int[] {10, 11, 12}
            };
        }

        #endregion

    }
}