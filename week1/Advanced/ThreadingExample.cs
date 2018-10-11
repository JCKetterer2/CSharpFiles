using System;
using System.Collections.Generic;
using System.Text;

namespace week1.Advanced
{
    public class ThreadingExample
    {
        public void SimpleMethod(int valueTotal)
        {
            for(int i = 0; i < valueTotal; i++)
            {
                Console.WriteLine("Hello Threading");
            }
        }

        public void DifferentMethod(object data)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Threading again {0}", data);
            }
        }
    }
}
