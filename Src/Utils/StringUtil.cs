using System;
using CrashCourse2020ExercisesDayOne.Src.Utils;

namespace CrashCourse2020ExercisesDayOne.Utils
{
    internal class StringUtil
    {
        internal int LengthOfString(string stringToMeasure)
        {
            if (stringToMeasure == null)
            {
                throw new NullReferenceException(Constants.StringCannotBeNull);
            }

            return stringToMeasure.Length;
        }

        internal string SumStrings(string value1, string value2)
        {
            return (int.Parse(value1) + int.Parse(value2)).ToString();
        }

        internal string DivideString(string value1, string value2)
        {
            return (int.Parse(value1) / int.Parse(value2)).ToString();
        }

        internal string StringContains(string value1, string value2)
        {
            if(value1.Contains(value2))
            {
                return "YES";
            }
            return "NO";

            // One - liner
            // return value1.Contains(value2) ? "YES" : "NO";
        }

        internal string StringToUpperCase(string value1)
        {
            return value1.ToUpper();
        }

        internal string AdditionFromPlusString(string inputString)
        {
            string[] values = inputString.Split("+");
            int sumValue = 0;
            foreach (string value in values)
            {
                sumValue += int.Parse(value);
            }
            return sumValue.ToString();
        }

        internal string EvenNumber(int numbertoTest)
        {
            return numbertoTest % 2 == 0 ? Constants.Even : Constants.Odd;
        }
    }
}