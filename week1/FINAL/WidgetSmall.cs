using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class WidgetSmall
    {
        private int _numOfGears   = 2;
        private int _numOfSprings = 3;
        private int _numOfLevers  = 1;

        public virtual int NumOfGears
        {
            set
            {
                this._numOfGears = value;
            }
            get
            {
                return _numOfGears;
            }
        }

        public virtual int NumOfSprings
        {
            set
            {
                this._numOfSprings = value;
            }
            get
            {
                return _numOfSprings;
            }
        }

        public virtual int NumOfLevers
        {
            set
            {
                this._numOfLevers = value;
            }
            get
            {
                return _numOfLevers;
            }
        }
    }
}
