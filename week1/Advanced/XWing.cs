using System;
using System.Collections.Generic;
using System.Text;

namespace week1.Advanced
{
    public class XWing
    {
        public string XWingType { get; set; }

        public int XWingRank { get; set; }

        public delegate void Fly(string type);

        public XWing(string type, int rank)
        {
            this.XWingType = type;
            this.XWingRank = rank;
        }

        public XWing()
        {
            Fly myXWing = FlyXWing;
        }

        public XWing(int rank)
        {
            this.XWingRank = rank;
        }


        //Method for a delegate
        public void FlyXWing(string message)
        {
            Console.WriteLine(message);
        }
    }
}
