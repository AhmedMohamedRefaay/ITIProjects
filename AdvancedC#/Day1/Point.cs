using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class Point : IComparable,ICloneable
    {
        int x, y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public object Clone()
        {
            return   new Point(x, y);
        }

        public int CompareTo(object obj)
        {
            Point point = obj as Point;
            if (this.x == point.x)
            {
                if (this.y == point.y)
                    return 0;
                else if (this.y > point.y)
                    return 1;
                else
                    return -1;


            }
            else if (this.x > point.x)
                return 1;
            else
                return -1;
        }

        public override string ToString()
        {
            return "("+this.x + " , " + this.y+")";
        }
    }
}
