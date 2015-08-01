using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProjectMath
{
    static class numberToLetters
    {

        public static string letters(int number)
        {
            /* input a number, return that number written out in letters
             * 
             * can chop off the last digit of a number by doing % 10
             * 
             * 
             */
            string letters = "";

            string[] oneToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                                     "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};


            if (number >= 0 && number <= 19)
            {
                return oneToNineteen[number];

            }

            return letters;


        }

    }
}
