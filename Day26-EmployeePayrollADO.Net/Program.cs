using System;

namespace Day26_EmployeePayrollADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
                
            //UC 5
            repository.GetEmployeesFromForDateRange("2021 - 02 - 01");
        }

        /// <summary>
        /// Adds the new employee into the database.
        /// </summary>
        public static void AddNewEmployee()
        {
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeModel model = new EmployeeModel();
            model.EmployeeName = "honey";
            model.Address = "Bihar";
            model.BasicPay = 45;
            model.Deductions = 454;
            model.Department = "IT";
            model.Gender = "F";
            model.PhoneNumber = 983798;
            model.NetPay = 833;
            model.Income_Tax = 32;
            model.StartDate = DateTime.Now;
            model.TaxablePay = 324;
            Console.WriteLine(repository.AddEmployee(model) ? "Record inserted successfully " : "Failed");
        }
    }
}
