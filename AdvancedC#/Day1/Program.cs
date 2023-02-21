using System;
using System.Collections;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5];
            points[0] = new Point(1, 2);
            points[1] = new Point(3, 3);
            points[2] = new Point(2, 2);
            points[3] = new Point(2, 3);
            points[4] = new Point(3, 2);
            Array.Sort(points);

           // IReadOnlyList<int> t = new List<int> { 1, 2, 4, 5, 6 };
            
            //for (int i = 0; i < points.Length; i++)
            //    Console.WriteLine( $"point {i+1}= "+points[i]);

            Trainee[] trainee = new Trainee[5];
             trainee[0] = new Trainee(33,"Ahmed");
            trainee[1] = new Trainee(31,"Mostaf");
            trainee[2] = new Trainee(30,"Ali");
            trainee[3] = new Trainee(43,"Hassan");
            trainee[4] = new Trainee(13,"Abdallah");
            TraineeCompare tr = new TraineeCompare();
            Array.Sort(trainee,tr);
                     
                for (int i = 0; i < trainee.Length; i++)
                    Console.WriteLine($"train {i + 1}= " + trainee[i]);
 #region  



            //Employee employee = new Employee(23232);
            //Console.WriteLine(employee.ShowPayment());

            //MyList myList = new MyList();
            //myList.Add(10);
            //myList.Add(11);
            //myList.Add(12);
            //myList.Add(1);
            //myList.Add(40);
            //myList.Add(15);

            //  IEnumerator iterat = myList.GetEnumerator();
            //while(iterat.MoveNext())
            //  {
            //      Console.WriteLine(iterat.Current);
            //  }
            //   iterat.Reset();
            // IEnumerator iterat1 = myList.GetEnumerator();
            //  while (iterat1.MoveNext())
            //  {
            //      Console.WriteLine(iterat1.Current);
            //  }

            //  foreach (var item in myList)
            //      Console.WriteLine(item);
            #endregion
            PhoneBook phoneBook = new PhoneBook ();


            try
            {
                phoneBook[22] ="Ahmed"; 
                Console.WriteLine(phoneBook["Ahmed"]);

                phoneBook["Hassan"] = 12;
                Console.WriteLine(phoneBook[12]);
            }
            catch (Exception ex)
            {
              
            }

            //Console.WriteLine(phoneBook[12]);

        }
    }
}
