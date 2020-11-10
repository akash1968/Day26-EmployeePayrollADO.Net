using System;

namespace Day26_EmployeePayrollADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            //UC 2
            repository.GetFullTableDetails();

            //UC 3
            Console.WriteLine(repository.UpdateSalaryIntoDatabase("Teressa", 30000) ? "Update done successfully " : "Update Failed");

            //UC 5
            repository.GetEmployeesFromForDateRange("2021 - 02 - 01");

            //UC 6
            repository.FindGroupedByGenderData();

            //UC 7
            repository.InsertIntoMultipleTablesWithTransactions();
        }

        /// <summary>
        /// Adds the new employee into the database.
        /// </summary>
        public static void AddNewEmployee()
        {
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeModel model = new EmployeeModel();
            model.EmployeeName = "sam";
            model.Address = "chennai";
            model.BasicPay = 30000;
            model.Deductions = 4000;
            model.Department = "Sales";
            model.Gender = "M";
            model.PhoneNumber = 983798;
            model.NetPay = 833;
            model.Income_Tax = 32;
            model.StartDate = DateTime.Now;
            model.TaxablePay = 2300;
            Console.WriteLine(repository.AddEmployee(model) ? "Record inserted successfully " : "Failed");
        }
    }
}
