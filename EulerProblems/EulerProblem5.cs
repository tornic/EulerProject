using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProblems
{
    static class EulerProblem5
    {
        public static double solve()
        {
            int num = 0;
            for (int i = 20; ; i++)
            {
                for (int j = 2; j <= 20; j++)
                {
                    if (i % j == 0)
                    {
                        num = i;
                    }
                    else
                    {
                        num = 0;
                        break;
                    }
                }
                if (num != 0)
                {
                    break;
                }
            }
            return num;
        }
    }
}
