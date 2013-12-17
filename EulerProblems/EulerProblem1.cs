using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProblems
{
    static class EulerProblem1
    {
        public static int solve()
        {
            List<int> nums = new List<int>();
            int answer = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    nums.Add(i);
                }

            }
            foreach (int element in nums)
            {
                answer += element;
            }

            return answer;
        }
    }
}
