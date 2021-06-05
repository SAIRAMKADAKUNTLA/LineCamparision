using System;
using System.Collections.Generic;
using System.Text;

namespace Line____Camparision
{
   public abstract class Line
    {
        public abstract void Comparelengths();
    }
    public class LineCompare : Line
    {
        public double LengthOne, LengthTwo;

        public override void Comparelengths()
        {
            Linecamparision linecamparision = new Linecamparision();
            linecamparision.Comparision(1, 3, 4, 5, 6, 7, 8, 9);

            if (LengthOne == LengthTwo)
            {
                Console.WriteLine("Both lines are equal");
            }
            else if (LengthOne > LengthTwo)
                Console.WriteLine("Lengthone is greater than lengthtwo");
            else
                Console.WriteLine("Lengthone is less than lengthtwo");
        }

      
        

    }
}
