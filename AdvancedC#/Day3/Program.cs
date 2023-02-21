using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {

            Company company =   new Company("IBM", 100000);


            Employee employee1 = new Employee("Ahmed", 3000);
            Employee employee2 = new Employee("Tarek", 2000);
            Employee employee3 = new Employee("Mohamed", 3500);
          
            employee1.InnSalary += company.DecreaseSalary;
            employee2.InnSalary += company.DecreaseSalary;
            employee1.IncreaseSalary(1000);
            employee2.IncreaseSalary(200.9);

            Console.WriteLine(company.Budget);

            ////////////////////////////////////////////////////////////
          
           List<Employee> employees= company.Filter(new List<Employee> 
           { employee1, employee2, employee3 }, x => x > 2200);

            foreach (Employee employee in employees)
                Console.WriteLine(employee.Name);
        }
    }
}
