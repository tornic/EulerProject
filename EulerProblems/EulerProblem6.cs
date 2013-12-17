using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProblems
{
    static class EulerProblem6
    {
        public static int solve()
        {
            int answer = 0;
            int SquareOfSum = 0;
            int SumOfSquares = 0;
            
            for (int i = 1; i <= 100; i++)
                SquareOfSum += i;            

            SquareOfSum = (int)Math.Pow(SquareOfSum, 2);
            
            for (int i = 1; i <= 100; i++)
                SumOfSquares += (int)Math.Pow(i, 2);
            
            answer = SquareOfSum - SumOfSquares;

            return answer;
        }
    }
}
