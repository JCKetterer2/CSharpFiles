using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class WidgetMedium : WidgetSmall
    {
        //Override auto properties with new default values
        public override int NumOfGears   { get; set; } = 4;
        public override int NumOfSprings { get; set; } = 5;
        public override int NumOfLevers  { get; set; } = 3;
    }
}
