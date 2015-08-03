using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerProject.EulerProjectMath;

namespace EulerProject.EulerProblems
{
    public static class EulerProblem7
    {
        public static long solve()
        {

            int answer = 0;
            int count = 0;
            int num = 2;
            bool loop = true;

            while (loop)
            {
                if (Prime.isPrime(num))
                {
                    count++;
                    answer = num;
                }
                num++;
                if (count == 10001)
                {
                    loop = false;
                }
                
            }                        
            return answer;
        }
    }
}
