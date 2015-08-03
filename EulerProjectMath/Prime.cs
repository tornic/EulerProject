using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProjectMath
{
    public static class Prime
    {
        /// <summary>
        /// Returns true if number is prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

    }
}
