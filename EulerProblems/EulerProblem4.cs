using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProblems
{
    public static class EulerProblem4
    {
        public static int solve()
        {
            int n = 0;
            int rev = 0;
            int dig = 0;
            int num = 0;
            List<int> palindromes = new List<int>();

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    num = i * j;
                    n = num;
                    rev = 0;
                    while (num > 0)
                    {
                        dig = num % 10;
                        rev = rev * 10 + dig;
                        num = num / 10;
                    }
                    if (n == rev)
                    {
                        palindromes.Add(n);
                    }
                }
            }
            return palindromes.Max();
        }        
    }
}
