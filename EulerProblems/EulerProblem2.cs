using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProblems
{
    static class EulerProblem2
    {
        public static long solve()
        {
            int a = 0;
            int b = 1;
            long result = 0;
            List<int> nums = new List<int>();

            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 1; a < 4000000; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                nums.Add(a);
            }
            
            foreach (int element in nums)
            {
                if (element % 2 == 0)
                {
                    
                    result += element;
                }
            }
            return result;
        }
        
    }
}
