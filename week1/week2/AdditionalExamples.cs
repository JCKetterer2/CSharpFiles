using System;
using System.Text;

namespace week1.week2
{
    public class AdditonalExamples
    {
        #region Params & Optional parameters

        public void UseParams(params int[] list)
        {
            Console.WriteLine(list[1].ToString());
        }

        public string GetText(string phrase)
        {
            string completedPhrase = MyBuilder(2);
            return completedPhrase;

            string MyBuilder(int valueAdd)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(phrase).Append(" ").Append(valueAdd);

                return builder.ToString();
            }
        }

        #endregion

        #region Method Overloading

        public void SomeMethod()
        {
            Console.WriteLine("Method with no paramters");
        }

        public void SomeMethod(String value)
        {
            Console.WriteLine("Method with 1 parameter that is {0}", value);
        }

        /* This method does not work because the return type can not overloaded with an already defined method */
        /* 
        public string SomeMethod() {
            return "Method with return value";
        }
        */

        public string SomeMethod(int value)
        {
            return "Method with return of string plus this int = " + value;
        }

        #endregion

        #region Null Operators

        public void CoalescingExample()
        {
            string s1 = null;
            string s2 = s1 ?? "happy";

            Console.WriteLine("The value for s2 = {0}", s2);
        }

        public void ElvisOperatorExample()
        {
            StringBuilder sb = null;

            string test = sb?.ToString();
            Console.WriteLine("The value of test = {0}", test);
        }

        #endregion

        #region Conditional Operators

        public bool UseUmbrella(bool rainy, bool sunny, bool windy)
        {
            return !windy && (rainy || sunny);
        }

        #endregion

    }
}