using System;

namespace Line____Camparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line camparision");
            Linecamparision linecamparision = new Linecamparision();
            linecamparision.Length(25,26,20,25);
            linecamparision.EqualOrNot(1, 3, 4, 5, 6, 7, 8, 9);
            linecamparision.Comparision(1, 3, 4, 5, 6, 7, 8, 9);
        }
    }
}
