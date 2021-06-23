using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryPortal_Without_OpenClosedPrinciple
{
    public class Employee
    {
        public double CalculateSalaryWithRewards(double currentSalary, AwardType awardType)
        {
            double finalSalary = 0;
            if (awardType == AwardType.BestPerformer)
            {
                finalSalary = currentSalary + 5000;
            }
            else if (awardType == AwardType.OutstandingPerformer)
            {
                finalSalary = currentSalary + 10000;
            }
            return finalSalary;
        }
    }
    public enum AwardType
    {
        BestPerformer,
        OutstandingPerformer
    };
}
