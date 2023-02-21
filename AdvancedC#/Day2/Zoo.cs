using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Zoo
    {
        public AnimalList animals { set; get; } = new AnimalList();

       
        public IReadOnlyList<Mammals> mammals
        {
            get
            {
               
               
                List<Mammals> mammalss = new List<Mammals>();
                foreach (Animal animal in animals)
                {
                    if (animal is Mammals)
                       
                        mammalss.Add((Mammals)animal);


                }
            
                return mammalss;
                
            }
        }
        public IReadOnlyList<Birds> birds
        {
            get
            {
                List<Birds> birdss = new List<Birds>();
                foreach (Animal animal in animals)
                {
                    if (animal is Birds)
                        birdss.Add((Birds)animal);

                }
                return birdss;
               
            }
           
        }

        public void Add(Animal animal)
        {
           
            
              animals.Add(animal);
   
        }
        public void Dies(Animal animal)
        {
            animals.Remove(animal);
        }
         
    }
}