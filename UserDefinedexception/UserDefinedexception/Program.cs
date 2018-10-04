﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedexception
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            try
            {
                Console.Write("Enter Employee ID :");
                emp.EmpID = Convert.ToInt32(Console.ReadLine());

                if (emp.EmpID < 100000 || emp.EmpID > 999999)
                    throw new EmployeeException("Employee Digit Should be 6 Digit long.");

                Console.Write("Enter Employee Name :");
                emp.EmpName = Console.ReadLine();

                if (emp.EmpName == string.Empty)
                    throw new EmployeeException("Employee Name Should be provided.");

                Console.Write("Enter Salary :");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                if(emp.Salary <10000)
                    throw new EmployeeException("Employee Salary Should be grater then 10000");

                Console.WriteLine("Employee ID :" + emp.EmpID);
                Console.WriteLine("Employee Name :" + emp.EmpName);
                Console.WriteLine("Employee Salary :"+ emp.Salary);
            }
            catch(EmployeeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
