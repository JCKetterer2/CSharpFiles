using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace week1.Homework6
{
    class ArrayListTesting
    {
        public ArrayList StarWarsArrayList()
        {
            ArrayList StarWarsTitlesAndYears = new ArrayList();

            StarWarsTitlesAndYears.Add("A New Hope");
            StarWarsTitlesAndYears.Add(1977);
            StarWarsTitlesAndYears.Add("Empire Strikes Back");
            StarWarsTitlesAndYears.Add(1980);
            StarWarsTitlesAndYears.Add("Return of the Jedi");
            StarWarsTitlesAndYears.Add(1983);

            return StarWarsTitlesAndYears;
        }
    }
}
