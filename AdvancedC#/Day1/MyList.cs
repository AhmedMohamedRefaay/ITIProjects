using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
   public class MyList:IEnumerable
    {
        int[] arr;
        int lastIndex,current;
        public MyList()
        {

            lastIndex = 0;
            current = -1;
            arr = new int[5];

        }
        public void Add(int value)
        {
            if (lastIndex == arr.Length)
            
              ExpandArray();
            
             arr[lastIndex] = value;
                lastIndex++;
               
        }

        void ExpandArray()
        {
            int[] NewArray = new int[arr.Length+10];
            for(int i=0;i<arr.Length;i++)
            {
                NewArray[i] = arr[i];
            }

            arr = NewArray;
        }

       
        public void Display()
        {
            for(int i=0;i<lastIndex;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        

        class Iterator:IEnumerator
        {
            int current;
            MyList myList;

           

            object IEnumerator.Current { get { return myList.arr[current]; }  }

            //   object IEnumerator.Current => throw new NotImplementedException();

            public Iterator(MyList myList)
            {
                current = -1;
                this.myList = myList;

            }
            public bool MoveNext()
            {
                current++;
                if (current <myList.lastIndex)
                    return true;
                else
                    return false;
            }
           

            public void Reset()
            {
                current = -1;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}
