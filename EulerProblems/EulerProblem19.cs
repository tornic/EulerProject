using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProblems
{
    public static class EulerProblem19
    {
        public static int solve()
        {
            int year = 1900;
            int month = 1;
            int sundayCount = 0;
            int dayOfWeek = 2;

            while (year <= 2000)
            {                
                for (int i = 1; i <= DaysInMonth(month, year); i++)
                {
                    if (year >= 1901)
                    {
                        if (i == 1 && dayOfWeek == 1)
                        {
                            sundayCount++;
                        }
                    }

                    dayOfWeek++;
                    if (dayOfWeek > 7)
                    {
                        //set day of the week to sunday
                        dayOfWeek = 1;
                    }                    
                }
                month++;

                if (month > 12)
                {
                    year++;
                    month = 1;
                }
            }            

            return sundayCount;
        }

        public static int DaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1: return 31;
                case 2: return DaysInFebruary(year);
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;        
            }
            return 0;
        }

        public static int DaysInFebruary (int year)
        {            
            return isLeapYear(year) ? 29: 28;
        }

        public static bool isLeapYear(int year)
        {            
            if(year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else
                    return false;
            }
            
            if(year % 4 == 0)
            {
                return true;
            }            
            return false;
        }  
    }
}
