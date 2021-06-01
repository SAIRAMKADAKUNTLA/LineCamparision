using System;
using System.Collections.Generic;
using System.Text;

namespace Line____Camparision
{

    public class Linecamparision
    {
        //UC1-LenthOfLine
        int x1, x2, y1, y2;
        public void Length(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            double Length = +(Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
            Console.WriteLine("Length of line =" + Length);

        }
        //UC2-EqualOrNot
        int x3, x4, y3, y4;
        public void EqualOrNot(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
            double LengthOne = +(Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
            double LengthTwo = +(Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2));
            if (LengthOne == LengthTwo)

                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both lines are not equal");
        }
    }
}
