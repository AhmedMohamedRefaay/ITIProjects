using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    interface  IPayable
    {

         double Salary { get; set; }
         double ShowPayment();

    }
}
