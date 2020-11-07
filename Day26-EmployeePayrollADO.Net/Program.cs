using System;

namespace Day26_EmployeePayrollADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Payroll");
            EmployeeRepository er = new EmployeeRepository();
            er.GetAllEmployees();
        }
    }
}
