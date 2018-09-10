using System;

namespace Week1.Homework2
{
    public class CountToTen
    {
        public void CountViaForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i);

                if(i <= 9)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}