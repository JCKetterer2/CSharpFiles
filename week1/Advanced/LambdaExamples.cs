using System;
using System.Collections.Generic;
using System.Text;

namespace week1.Advanced
{
    public class LambdaExamples
    {
        private int _myInt = 6;

        public int MyValue
        {
            //((value passed in + 4) squared) = result displayed, via mySecond.MyValue in program.cs
            get => _myInt + 4;

            set
            {
                _myInt = value;
            }                    // also produce same result...  set => _myInt = value
        }

        delegate int del(int i);

        public LambdaExamples() { }

        public LambdaExamples(int value) => MyValue = value;


        public int MyLambdaOne(int value)
        {
            //(parameters) => expression-or-statement-block
            del myDelegate = x => x * x;
            return myDelegate(value);
        }
    }
}
