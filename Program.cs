using System;

namespace Wages_for_month
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDays = 20;
        public const int maxHrsInMonth = 100;
        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsInMonth  && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case isPartTime: 
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}

    

