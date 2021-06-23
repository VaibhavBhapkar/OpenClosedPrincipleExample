using System;

namespace EmployeeSalaryPortal_Without_OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            double finalSalary = employee.CalculateSalaryWithRewards(20000, AwardType.BestPerformer);
            Console.WriteLine(finalSalary);
        }
    }
}
