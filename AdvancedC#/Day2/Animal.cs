using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
     delegate void remove(Animal animal);
    class Animal
    {
        public event remove remov;
       public int Age { get; set; }

  
        public Animal(int Age)
        {
           this.Age = Age;
        }
         
        public void Die()
        {
            remov.Invoke(this);
        }
    } 
}
