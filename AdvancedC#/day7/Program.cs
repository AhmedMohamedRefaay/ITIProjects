using System;
using System.Threading;

namespace day7
{
    class Program
    {
        static void sumOdd()
        {
            long sum = 0;
            for (int i = 0; i < 1000000; i++)
                if (i % 2 != 0)
                {
                    sum += i;


                }
            Console.WriteLine($"sum odd : {sum }");
        }
        static void sumEven()
        {
            long sum = 0;
            for (int i = 0; i < 1000000; i++)
                if (i % 2 == 0)
                {

                    sum += i;

                }

            Console.WriteLine($"sum even : {sum}");
        }
        static void sumTotal()
        {
            long sum = 0;
            for (int i = 0; i < 100000; i++)
                sum += i;


            Console.WriteLine($"sum Total : {sum}");
        }

        static int sumArrayWithMultiThreads(int[]arr,Thread[]threads)
        {
            int totalsumThread = 0;
         

            int threadSize = arr.Length / threads.Length;
             
            for(int i=0;i<threads.Length;i++)
            {
                int startThread = i * threadSize;
                int endThread = startThread + threadSize - 1;
                if (i == threads.Length - 1)
                    endThread += arr.Length % threads.Length;
                threads[i] = new Thread(
                    ()=>
                    {
                        int ThreadSum = 0;

                        for (int j = startThread; j <= endThread; j++)
                            ThreadSum += arr[j];
                        totalsumThread += ThreadSum;
                    }
                    );
                threads[i].Start();
               
               
            }

            for (int i = 0; i < threads.Length; i++)
            { 
                threads[i].Join();
            }

                return totalsumThread;
        }

        static long sumEvenfromArray(int[]arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    sum += arr[i];
            Console.WriteLine("EVEEEEEEEEEEEEEEEN");
            return sum;

        }

        static long sumOddfromArray(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 != 0)
                    sum += arr[i];

            Console.WriteLine("ODDDDDDDDDDDDDDDDDDDDDDDDDDDDd");
            return sum;

        }
        static int[] GenertaArray()
        {
            int[] arr = new int[10];
            Random rnd = new Random();

            for (int j = 0; j < arr.Length; j++)
            {

                arr[j] = rnd.Next(1,100);
            }

            return arr;
        }
      
        
        static void Main(string[] args)
        {

            #region
            //Thread thread1 = new Thread(sumOdd);
            //Thread thread2 = new Thread(sumEven);
            //Thread thread3 = new Thread(sumTotal);


            //thread1.Start();

            //thread2.Start();

            //thread3.Start();

            //int[] arr = GenertaArray();
            //long sumeve =1;
            //long sumodd =0;
            //Thread thread4 = new Thread(() => sumeve = sumEvenfromArray(arr));
            //Thread thread5 = new Thread(() => sumodd = sumOddfromArray(arr));
            //thread4.Start();
            //thread5.Start();
            //Thread.Sleep(1000);
            //Console.WriteLine($"Even from Array:  {sumeve}");
            //Console.WriteLine("Odd from Array: " + sumodd);
            //long total = sumeve + sumodd; 
            //Console.WriteLine("Total from array: " + total);

            #endregion


            int[] arr = GenertaArray();

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Thread[] threads = new Thread[6];
            Console.WriteLine("-------------------------------------------------");
            int sum = sumArrayWithMultiThreads(arr,threads);
            Console.WriteLine(sum);

           
        }
    }
}