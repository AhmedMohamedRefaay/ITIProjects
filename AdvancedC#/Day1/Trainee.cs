using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Day1
{
   public class Trainee : IPayable, IComparable<Trainee> { 
        public double Salary { get; set; }

        public string Name { get; set; }
        public Trainee(double sal,string Name)
        {
            Salary = sal;
            this.Name = Name;
        }
        public double ShowPayment()
        {
            return Salary;
        }
    
        public override string ToString()
        {
            return Salary.ToString()+","+Name;
        }

        public int CompareTo(Trainee other)
        {
               if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }

         
    }
    public class TraineeCompare : IComparer<Trainee>
    {
        public int Compare(Trainee x, Trainee y)
        {

            return String.Compare(x.Name, y.Name);
        }
    }
}
