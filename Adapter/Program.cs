using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Employee list from 3rd party organization system.");

            ITarget adapter = new EmployeeAdapter();

            foreach (string employee in adapter.GetEmployees())
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }

    // Adaptee class
    class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> EmployeeList = new List<string>();
            EmployeeList.Add("Peter");
            EmployeeList.Add("Paul");
            EmployeeList.Add("Puru");
            EmployeeList.Add("Preethi");
            return EmployeeList;
        }
    }
    // ITarget interface
    interface ITarget
    {
        List<string> GetEmployees();
    }
    // Adapter class
    class EmployeeAdapter : ThirdPartyEmployee, ITarget
    {
        public List<string> GetEmployees()
        {
            return GetEmployeeList();
        }
    }
}
