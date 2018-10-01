using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class WidgetLarge : WidgetSmall
    {
        //Override auto properties with new default values
        public override int NumOfGears   { get; set; } = 9;
        public override int NumOfSprings { get; set; } = 4;
        public override int NumOfLevers  { get; set; } = 2;
    }
}
