using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryPortal_With_OpenClosedPrinciple
{
    public class OutstandingPerformer:Employee
    {
        public override double CalculateSalaryWithRewards(double currentSalary)
        {
            return currentSalary + 10000;
        }
    }
}
