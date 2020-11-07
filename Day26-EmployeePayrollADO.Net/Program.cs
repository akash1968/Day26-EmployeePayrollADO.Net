﻿using System;

namespace Day26_EmployeePayrollADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC 2
            EmployeeRepository repository = new EmployeeRepository();
            repository.GetAllEmployees();

            //UC 3
            Console.WriteLine(repository.UpdateSalaryIntoDatabase("Teressa", 30000) ? "Update done successfully " : "Update Failed");
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
