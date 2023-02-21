using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Pigeon:Birds
    {
      
        public Pigeon(int Age):base(Age)
        {
             
        }
        public override string ToString()
        {

            return "Pigeon";
        }
    }
}
