using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModule
{
    public static class TheStudyClass
    {

        public static double SelfStudy(int numberOfCreds,DateTime Startdate,int NumberOFWeeks,double HoursPerWeek) {

            double selfStudyhrs;
           
            selfStudyhrs = (numberOfCreds * 10 / NumberOFWeeks) - HoursPerWeek;

            return selfStudyhrs;
        }

        public static double TotalhrsPreMod(int numberOfCreds, DateTime Startdate, int NumberOFWeeks, double HoursPerWeek)
        {

            double TotalselfStudyhrs;
            
            double selfStudyhrs = (numberOfCreds * 10 / NumberOFWeeks) - HoursPerWeek;

            TotalselfStudyhrs = NumberOFWeeks * selfStudyhrs;

            return TotalselfStudyhrs;
        }
    }
}
