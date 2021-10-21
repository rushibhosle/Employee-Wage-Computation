using System;

namespace EmployeeWagesComputationProgram
{
    class Program
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("welcome message of Employee wages");

            int empHrs = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;
            //for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)

            while (totalEmpHr <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 2);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                /*
                if (empCheck == IS_FULL_TIME)
                {
                    empHrs = 8;
                }
                else if (empCheck == IS_PART_TIME)
                {
                    empHrs = 4;
                }
                else
                {
                    empHrs = 0;
                }
                if (empCheck == IS_FULL_TIME)
                {
                    //Console.WriteLine("Employee is prsent");
                    empHrs = 8;
                }
                else
                {
                    empHrs = 0;
                }
                /* else
                 {
                     Console.WriteLine("Employee is absent");
                 }*/

                //empWage = empHrs * EMP_RATE_PER_HOUR;
                //totalEmpWages = totalEmpWages + empWage;
                totalEmpHr += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "emp Hrs" + empHrs);
            }
            int totalEmpWages = totalEmpHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("total employee wage is=" + totalEmpWages);
        }
    }
}