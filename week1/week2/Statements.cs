using System;
namespace week1.week2
{
    public class Statements
    {
        private string _something = "test something", someOther = "test other";

        #region Constant

        private const int _someNumber = 42;

        public void ConstantExample()
        {
            // someNumber = 24;  // can't change
            Console.WriteLine("The answer to Life Universe and Everything = {0}!", _someNumber);
        }

        #endregion

        /**
         * Expression statements must change state or call something that may change state.
         * 
         * **/
        public void ExpressionStatementExample(int value, int otherValue)
        {
            int multi = value * otherValue; // assignment expression
            Console.WriteLine("Your first value = {0}.", value); // method call expression
            Console.WriteLine("Your numbers multiplied is {0}", multi); // method call expression
            value++; // Increment expression
            Console.WriteLine("Your first value increased = {0}.", value); // method call expression
        }

        /**
         * Selection if Statement that will execute a set of code if the expression is true, or false.
         * If statements can be chained together using the else if, but using a switch is more efficiant.
         * **/
        public void IfStatementBasicExample(int value, int secondValue)
        {
            if (value.Equals(secondValue))  // value == secondValue
            {
                Console.WriteLine("Both values are the same.");
            }
            else
            {
                Console.WriteLine("Both values are different.");
            }
        }

        public void IfStatementChainExample(string day)
        {
            if (day.Equals("Sunday"))
            {
                Console.WriteLine("Sunday choosen true");
            }
            else if (day.Equals("Monday"))
            {
                Console.WriteLine("Monday choosen true");
            }
            else if (day.Equals("Tuesday"))
            {
                Console.WriteLine("Tuesday choosen true");
            }
            else if (day.Equals("Wednesday"))
            {
                Console.WriteLine("Wednesday choosen true");
            }
            else if (day.Equals("Thursday"))
            {
                Console.WriteLine("Thursday choosen true");
            }
            else if (day.Equals("Friday"))
            {
                Console.WriteLine("Friday choosen true");
            }
            else if (day.Equals("Saturday"))
            {
                Console.WriteLine("Saturday choosen true");
            }
            else
            {
                Console.WriteLine("No day choosen.");
            }
        }

        public void SwitchStatemntExample(string day)
        {
            switch (day)
            {
                case "Sunday":
                    Console.WriteLine("Sunday choosen true");
                    break;
                case "Monday":
                    Console.WriteLine("Monday choosen true");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday choosen true");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday choosen true");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday choosen true");
                    break;
                case "Friday":
                    Console.WriteLine("Friday choosen true");
                    break;
                case "Saturday":
                    Console.WriteLine("Saturday choosen true");
                    break;
                default:
                    Console.WriteLine("No day choosen.");
                    break;
            }
        }

        /**
         *  Iteration Statements perform an action while the expression is true. 
         *  These statements are while, do while, for & foreach loops
         * **/
        public void WhileLoopExample()
        {
            int i = 0;
            while (i < 10) // While this expression is true
            {
                //perform these actions after the expression is checked
                Console.WriteLine(_something);
                i++;
            }
        }

        public void DoWhileLoopExample()
        {
            int j = 0;
            do
            {
                //perform these actions atleast once before the expression is checked
                Console.WriteLine(someOther);
                j++;
            } while (j < 5); // While this expression is true
        }

        public void ForLoopExample()
        {
            for (int i = 0; i < 5; i++)
            {
                ConstantExample();
            }
        }

        public void ForEachLoopExample()
        {
            foreach (char ch in "Something")
            {
                Console.WriteLine(ch);
            }
        }

        public string JumpStatementExample(string day)
        {
            switch (day)
            {
                case "Sunday":
                    goto default;
                case "Monday":
                case "Tuesday":
                    return _something;
                default:
                    return someOther;
            }
        }
    }
}