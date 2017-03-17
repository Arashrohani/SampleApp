using System;
using System.Collections.Generic;
using System.Text;
using SampleApp.Core.Entities;

namespace SampleApp.Business
{
    public class EmployeeData
    {
        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    EmployeeNumber = "E1020304",
                    FirstName = "John",
                    LastName = "Doe",
                    Department = new Department
                    {
                        Division = "Executive",
                        Name = "Human Resources"
                    },
                    HomeAddress = new Address
                    {
                        StreetNumber = "123",
                        StreetName = "Main",
                        City = "Big City",

                    }
                },
                new Employee
                {
                    EmployeeNumber = "E220909",
                    FirstName = "Patrick",
                    LastName = "Jane",
                    Department = new Department
                    {
                        Division = "Finance",
                        Name = "Financial Resources"
                    },
                    HomeAddress = new Address
                    {
                        StreetNumber = "321",
                        StreetName = "Sub Train",
                        City = "Small City",

                    }
                }
            };
        }
    }
}
