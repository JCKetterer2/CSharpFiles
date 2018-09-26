using System;
using System.Collections.Generic;
using System.Text;

namespace week1.Advanced
{
    //Delegate
    public delegate string MyCoat(string message);

    public class Coats
    {
        //Event Declaration
        public event MyCoat MyEventCoat;

        public string MyResult { get; private set; }

        public Coats()
        {
            //Add delegate to event
            this.MyEventCoat += new MyCoat(this.MyFavoriteCoat);

            //Assign result from event to a property
            MyResult = MyEventCoat("Trench");
        }

        public string MyFavoriteCoat(string message)
        {
            return "My favorite coat is " + message;
        }
    }
}
