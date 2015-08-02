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
             * can get the last 2 digits by % 100
             * 
             */            
            
            string[] oneToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                                     "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            string[] twentyToNinety = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };


            if (number >= 1 && number <= 19)
            {
                return oneToNineteen[number];

            }

            if (number >= 20 && number <=29)
            {                                
                return "Twenty" + letters(number % 10);

            }
            
            if (number >= 30 && number <= 39)
            {
                return "Thirty" + letters(number % 10);

            }

            if (number >= 40 && number <= 49)
            {
                return "Forty" + letters(number % 10);

            }

            if (number >= 50 && number <= 59)
            {
                return "Fifty" + letters(number % 10);

            }

            if (number >= 60 && number <= 69)
            {
                return "Sixty" + letters(number % 10);

            }

            if (number >= 70 && number <= 79)
            {
                return "Seventy" + letters(number % 10);

            }

            if (number >= 80 && number <= 89)
            {
                return "Eighty" + letters(number % 10);

            }
            if (number >= 90 && number <= 99)
            {
                return "Ninety" + letters(number % 10);

            }

            if (number == 100)
            {
                return "OneHundred";

            }

            if (number > 100 && number <= 199)
            {
                return "OneHundredAnd" + letters(number % 100);

            }

            if (number == 200)
            {
                return "TwoHundred";

            }

            if (number > 200 && number <= 299)
            {
                return "TwoHundredAnd" + letters(number % 100);

            }

            if (number == 300)
            {
                return "ThreeHundred";

            }

            if (number > 300 && number <= 399)
            {
                return "ThreeHundredAnd" + letters(number % 100);

            }

            if (number == 400)
            {
                return "FourHundred";

            }

            if (number > 400 && number <= 499)
            {
                return "FourHundredAnd" + letters(number % 100);

            }

            if (number == 500)
            {
                return "FiveHundred";

            }

            if (number > 500 && number <= 599)
            {
                return "FiveHundredAnd" + letters(number % 100);

            }

            if (number == 600)
            {
                return "SixHundred";

            }

            if (number > 600 && number <= 699)
            {
                return "SixHundredAnd" + letters(number % 100);

            }

            if (number == 700)
            {
                return "SevenHundred";

            }
            if (number > 700 && number <= 799)
            {
                return "SevenHundredAnd" + letters(number % 100);

            }

            if (number == 800)
            {
                return "EightHundred";

            }

            if (number > 800 && number <= 899)
            {
                return "EightHundredAnd" + letters(number % 100);

            }

            if (number == 900)
            {
                return "NineHundred";

            }

            if (number > 900 && number <= 999)
            {
                return "NineHundredAnd" + letters(number % 100);

            }

            if (number == 1000)
            {
                return "OneThousand";

            }

            
            return "";


        }

    }
}
