using System;

namespace week1.week2
{
    public class NumericTypes
    {
        #region Integral - Signed
        private sbyte _mySbyteValue = 2;
        private short _myShortValue = 4;
        private int _myIntValue = 25000;
        private long _myLongValue = 1_234_567L;
        private long _myLongValue2 = 0x5F;
        #endregion
    
        #region Integral - Unsigned
        private byte _myByteValue = 3;
        private ushort _myUshortValue = 35;
        private uint _myUintValue = 2345U;
        private ulong _myUlongValue = 1234UL;
        #endregion

        #region Real
        private float _myFloatValue = -123.6589F;
        private double _myDoubleValue = 12.34D;  //the "D" for double is not required
        private double _myDoubleValue2 = 1E06;
        private double _myDoubleValue3 = 12.34;
        private decimal _myDecimalValue = 12.234M;
        #endregion

        public void ConvertFloatToInt()
        {
            //Explicit conversion... using "casting" of type
            //decimal-based to non decimal-based, no rounding
            int converted = (int)_myFloatValue;
        }

        public void LongFromInt()
        {
            //Implicit conversion... does not require a "cast"
            long someValue = _myIntValue;
        }

        //example of method overloading (same method name as above, but with parameter)
        public long LongFromInt(int value)
        {
            return value;
        }

        public void IncrementDecrement()
        {
            int myVal = 1, myOtherVal = 10; //variable declaration

            Console.WriteLine(myVal++);
            Console.WriteLine(myOtherVal--);
            Console.WriteLine(--myVal);
            Console.WriteLine(++myOtherVal);
        }

        public void GetSomeTypes()
        {
            Console.WriteLine(3.0.GetType());
            Console.WriteLine(_myFloatValue.GetType());
        }

        public void BasicMath()
        {
            int myVal = 5, myOtherVal = 10; //variable declaration

            int addVal = myVal + myOtherVal;
            int subtractVal = myOtherVal - myVal;
            int multiplyVal = myOtherVal * myVal;
            int divisionVal = myVal / myOtherVal;

            int total = (addVal * multiplyVal) - divisionVal;

            Console.WriteLine(addVal);
            Console.WriteLine(subtractVal);
            Console.WriteLine(multiplyVal);
            Console.WriteLine(divisionVal);
            Console.WriteLine(total);
        }

        public void CheckOperatorType()
        {
            int val = 100, val2 = 100;

            //this .....
            int testValue = checked(val * val2);

            //and this.... do the same thing (slide p.13)
            checked
            {
                int myCheck = val * val2;
            }

            Console.WriteLine(testValue);
        }

        public void SpecialValues()       //see slide deck for NaN and special values
        {
            Console.WriteLine(2.0 / 0.0);
            Console.WriteLine(-2.0 / 0.0);
            Console.WriteLine(2.0 / -0.0);
            Console.WriteLine(-2.0 / - 0.0);
            Console.WriteLine(0.0 / 0.0);
            Console.WriteLine((2.0 / -0.0) - (2.0 / 0.0));
            Console.WriteLine(0.0 / -0.0 == double.NaN);
            Console.WriteLine(double.IsNaN(0.0 / 0.0));
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));
        }

        public void MyCheckComparison()
        {
            int blue = 10, red = 12, green = 10;
            //Equality Comparison
            Console.WriteLine(blue == green);
            //InEquality Comparison
            Console.WriteLine(red != blue);     
        }   
    }
}