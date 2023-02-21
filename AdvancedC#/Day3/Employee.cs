using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    delegate void InSalary(double amount);
    class Employee
    {
        
        public string Name { set; get; }
        public double Salary { set; get; }

        public event InSalary InnSalary;
        
        public Employee(string _Name, double _Salary)
        {
            Name = _Name;
            Salary = _Salary; ;
        }

        
        public void IncreaseSalary(double Amount)
        {

             Salary += Amount;
            InnSalary.Invoke(Amount);
        }
    }

}
