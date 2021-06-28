using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the values of co-oridinates");
            int x1 = Convert.ToInt32( Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double Length_of_Line = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the line is : " + Length_of_Line);
            Console.Read();


        }
    }
}
