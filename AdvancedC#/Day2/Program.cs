using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            //zoo.Add(new Lion(10));
            //zoo.Add(new Elephant(11));
            //zoo.Add(new Pigeon(12));
            //zoo.Add(new Sparrow(13));

            //zoo.Add(new Lion(14));
            //zoo.Add(new Elephant(13));
            //zoo.Add(new Pigeon(12));
            //zoo.Add(new Sparrow(10));

            //zoo.Add(new Lion(121));
            //zoo.Add(new Elephant(1));
            //zoo.Add(new Pigeon(1));
            //zoo.Add(new Sparrow(12));

            zoo.Add(new Lion(22));
            zoo.Add(new Elephant(5));
            zoo.Add(new Pigeon(19));
            zoo.Add(new Sparrow(9));

            Lion lion = new Lion(1);
            
            zoo.Add(lion);

            

            foreach (Animal animal in zoo.mammals)
                Console.WriteLine("Mammals:" + animal);

            Console.WriteLine("-------------------------------------------------------");
            foreach (Animal animal in zoo.birds)
                Console.WriteLine("Birds:" + animal);
       
            lion.remov += zoo.Dies;
            lion.Die();
          
            

            Console.WriteLine("-------------------------------------------------------");
            foreach (Animal animal in zoo.animals)
                Console.WriteLine("Animal:" + animal);


        }
    }
}
