using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProblems
{
    static class EulerProblem17
    {
        //If the numbers 1 to 5 are written out in words: one, two, three, four, five, then
        //there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

        //If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words,
        //how many letters would be used?

        //NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two)
        //contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
        //The use of "and" when writing out numbers is in compliance with British usage.

        // three hundred and forty two
        // seven hundred and forty two

        /*
         * one, two, three, four, five, six, seven, eight, nine, ten
         * 
         * eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen
         * eightteen, nineteen
         * 
         * twenty, thirty, fourty, fifty, sixty, seventy, eighty, ninty
         * 
         * one-hundred, two-hundred
         * 
         * and
         * 
         * group 1: one, two, six, ten (count 1 multply by 4)
         * group 2: three, seven, eight (count 1 multiply by 3)
         * group 3: four, five, nine (count 1 multply by 3)
         * 
         * group 1: twenty, thirty, eighty, ninety (count 1 multiply by 4)
         * group 2: forty, fifty, sixty (count 1 multiply by 5)
         * group 3: seventy (count 1 multiply by 7)
         * 
         *  string twenty = "twenty";
            string thirty = "thirty";
            string forty = "forty";
            string fifty = "fifty";
            string sixty = "sixty";
            string seventy = "seventy";
            string eighty = "eighty";
            string ninety = "ninety";

         */

        public static string solve()
        {
            string numbers = "";

            for (int i = 1; i <= 19; i++)
            {
                numbers += EulerProjectMath.numberToLetters.letters(i);

            }



                /*
                List<string> numbers = new List<string>();
                List<string> singleDigits = new List<string>();
                List<string> doubleDigits = new List<string>();

                List<string> hundreds = new List<string>();

                doubleDigits.Add("eleven");
                doubleDigits.Add("twelve");
                doubleDigits.Add("thirteen");
                doubleDigits.Add("fourteen");
                doubleDigits.Add("fifteen");
                doubleDigits.Add("sixteen");
                doubleDigits.Add("seventeen");
                doubleDigits.Add("eighteen");
                doubleDigits.Add("nineteen");

                string one = "one";
                string two = "two";
                string three = "three";
                string four = "four";
                string five = "five";
                string six = "six";
                string seven = "seven";
                string eight = "eight";
                string nine = "nine";
                string ten = "ten";

                string twenty = "twenty";
                string thirty = "thirty";
                string forty = "forty";
                string fifty = "fifty";
                string sixty = "sixty";
                string seventy = "seventy";
                string eighty = "eighty";
                string ninety = "ninety";

                singleDigits.Add(one);
                singleDigits.Add(two);
                singleDigits.Add(three);
                singleDigits.Add(four);
                singleDigits.Add(five);
                singleDigits.Add(six);
                singleDigits.Add(seven);
                singleDigits.Add(eight);
                singleDigits.Add(nine);
            

                foreach (string num in singleDigits)
                {
                    numbers.Add(num);

                }
                numbers.Add(ten);

                numbers.Add("eleven");
                numbers.Add("twelve");
                numbers.Add("thirteen");
                numbers.Add("fourteen");
                numbers.Add("fifteen");
                numbers.Add("sixteen");
                numbers.Add("seventeen");
                numbers.Add("eighteen");
                numbers.Add("nineteen");
                numbers.Add(twenty);

                foreach (string num in singleDigits)
                {
                    numbers.Add(twenty + num);

                }
                numbers.Add(thirty);

                foreach (string num in singleDigits)
                {
                    numbers.Add(thirty + num);

                }
                numbers.Add(forty);

                foreach (string num in singleDigits)
                {
                    numbers.Add(forty + num);

                }
                numbers.Add(fifty);

                foreach (string num in singleDigits)
                {
                    numbers.Add(fifty + num);

                }
                numbers.Add(sixty);

                foreach (string num in singleDigits)
                {
                    numbers.Add(sixty + num);

                }
                numbers.Add(seventy);

                foreach (string num in singleDigits)
                {
                    numbers.Add(seventy + num);

                }
                numbers.Add(eighty);

                foreach (string num in singleDigits)
                {
                    numbers.Add(eighty + num);

                }
                numbers.Add(ninety);

                foreach (string num in singleDigits)
                {
                    numbers.Add(ninety + num);

                }

                foreach (string num in singleDigits)
                {
                    hundreds.Add("100" + num);

                }

                foreach (string num in doubleDigits)
                {
                    hundreds.Add("100" + num);

                }

                */
                return numbers;
        }
    }
}
