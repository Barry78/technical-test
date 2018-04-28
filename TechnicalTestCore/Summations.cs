using TechnicalTestUtilities;
using System;


namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNr)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int n = 0;
            int sum1 = 0;
            int x = 1;
            while (n < maxNr)
            {
                sum1 = sum1 + x;
                n++;
                x++;
            }
            return sum1;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int a = 1;
            long sum2 = 1;
            int b = 2;
            int maxNrAsInt = Convert.ToInt32(maxNrAsString);

            while (a < maxNrAsInt)
            {
                sum2 = sum2 + b;
                a++;
                b++;
            }

             string final = Convert.ToString(sum2);

            return final;
        }
    }
}

