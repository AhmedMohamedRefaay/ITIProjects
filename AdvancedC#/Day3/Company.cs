using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Company
    {

       
        public string Name { set; get; }
         public double Budget { set; get; }
        public List<Employee> employees { set; get; } = new List<Employee>();


        public Company(string _Name,double _Budget)
        {
            Name = _Name;
            Budget = _Budget;
        }
        public List<Employee> Filter(List<Employee> employeess,Predicate<double> predicate)
        {
            List<Employee> employeesFilter = new List<Employee>();
            foreach(Employee employee in employeess)
            {
                if (predicate(employee.Salary))
                    employeesFilter.Add(employee);

            }
            return employeesFilter;

        }

        public void DecreaseSalary(double Amount)
        {

            Budget -= Amount;
           
        }
    }
}
