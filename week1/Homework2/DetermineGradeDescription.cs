using System;

namespace Week1.Homework2
{
    public class DetermineGradeDescription
    {
        public string EvaluateGrade(char grade)
        {
            switch (grade)
            {
                case 'E':
                    return "Excellent";

                case 'V':
                    return "Very Good";

                case 'G':
                    return "Good";

                case 'A':
                    return "Average";

                case 'F':
                    return "Fail";

                default:
                    return "Invalid grade value";
            }
        }
    }
}