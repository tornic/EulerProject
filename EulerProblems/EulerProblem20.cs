using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace EulerProject.EulerProblems
{
    public static class EulerProblem20
    {
        public static BigInteger solve()
        {
            BigInteger answer = Factorial(100);

            //int prev = 0;

            int final = 0;

            while (answer > 0)
            {
                int temp = (int)(answer % 10);


                final = final + temp;
                //prev = temp;
                answer = answer / 10;



            }          


            return final;
        }

        public static BigInteger Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

    }
}
