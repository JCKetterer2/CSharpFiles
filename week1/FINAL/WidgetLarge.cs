using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    /* (backup)
    public class WidgetLarge : WidgetSmall
    {
        //Override auto properties with new default values
        public override int NumOfGears { get; set; } = 9;
        public override int NumOfSprings { get; set; } = 4;
        public override int NumOfLevers { get; set; } = 2;
    }
    */

    public class WidgetLarge : WidgetSmall
    {
        /* (backup)
        //Override auto properties with new default values
        public override int NumOfGears   { get; set; } = 9;
        public override int NumOfSprings { get; set; } = 4;
        public override int NumOfLevers  { get; set; } = 2;
        */

        //Override auto properties with new default values
        public override int NumOfGears { get; set; }
        public override int NumOfSprings { get; set; }
        public override int NumOfLevers { get; set; }
    }
}
