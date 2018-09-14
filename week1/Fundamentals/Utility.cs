using System;

namespace week1.Fundamentals
{
    public static class Utility
    {
        const int _myFirst = 5;
        static int _mySecond = 7;

        //constructor cannot have access modifiers (ie: public)
        //and it is automatically called
        static Utility()
        {
            _mySecond = 10;
            Console.WriteLine("Utility Constructor");
        }

        //second parameter is optional and has default value (if not passed, it has value of _myfirst)
        public static int AddTwoNumbers(int value1, int value2 = _myFirst)
        {
            value1 = _mySecond + value1;
            return value1 + value2;
        }
    }
}