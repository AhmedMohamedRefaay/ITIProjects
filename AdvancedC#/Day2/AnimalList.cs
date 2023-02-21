using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class AnimalList : List<Animal>
    {
      
        public new void Add(Animal animal)
        {

            if (animal.Age < 10)
                base.Add(animal);
 
        }

      


    }
}
