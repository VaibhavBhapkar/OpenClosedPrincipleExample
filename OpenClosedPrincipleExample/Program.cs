using EmployeeSalaryPortal_With_OpenClosedPrinciple;
using System;

namespace OpenClosedPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bestPerformerEmployee = new BestPerformer();
            Employee outstandingPerformerEmployee = new OutstandingPerformer();
            double bestPerformerSalary = bestPerformerEmployee.CalculateSalaryWithRewards(30000);
            double outstandingPerformerSalary = outstandingPerformerEmployee.CalculateSalaryWithRewards(30000);
            Console.WriteLine(bestPerformerSalary);
            Console.WriteLine(outstandingPerformerSalary);
        }
    }
}
