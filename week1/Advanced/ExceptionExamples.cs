using System;
using System.Collections.Generic;
using System.Text;

namespace week1.Advanced
{
    public class ExceptionExamples
    {
        string exampleNull = null;

        public void MyException()
        {
            try
            {
                Console.WriteLine(exampleNull.Trim());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null exception thrown " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("exception thrown " + e.Message);
            }
        }

        public void MySecondExample()
        {
            try
            {
                exampleNull = "No longer null";
                Console.WriteLine(exampleNull.ToUpper());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null exception thrown " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block was called");
            }
        }

        public void MyThirdExample()
        {
            //string[] names = { "Matt", "Dave", "John" };
            string[] names = { "1111111007", "2222222011", "333333009" };
            try
            {
                byte b = byte.Parse(names[1]);
                Console.WriteLine(b);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provide at least one argument!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("That's not a number!");
            }
            catch (OverflowException eo)
            {
                Console.WriteLine("You've given me more that a byte!");
            }
        }
    }
}
