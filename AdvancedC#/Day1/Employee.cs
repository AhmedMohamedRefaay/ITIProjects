using System;
using System.Collections.Generic;
using System.Text;
namespace Day1
{
    class Employee : IPayable
    {
        public double Salary { get; set; }

        public Employee(double sal) { Salary = sal; }
        public double ShowPayment()
        {
            return Salary;
        }
    }
}
