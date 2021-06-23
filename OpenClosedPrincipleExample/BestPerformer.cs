using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryPortal_With_OpenClosedPrinciple
{
    public class BestPerformer:Employee
    {
        public override double CalculateSalaryWithRewards(double currentSalary)
        {
            return currentSalary+5000;
        }
    }
}
