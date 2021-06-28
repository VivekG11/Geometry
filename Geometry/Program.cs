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
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
            double Length_of_Line = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the line is : " + Length_of_Line);
            double Length_of_Line_Two = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of the line is : " + Length_of_Line_Two);
            

            if (Length_of_Line.Equals(Length_of_Line_Two))
            {
                Console.WriteLine( "Both Lines are equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.WriteLine("Comparing two Lines ");

            switch(Length_of_Line .CompareTo(Length_of_Line_Two))
            {
                case 1:
                    Console.WriteLine("First line is greater than Second Line");
                    break;
                case 2:
                    Console.WriteLine("Second Line is Greater then First Line");
                    break;
                default:
                    Console.WriteLine("Both Lines Re Equal");
                    break;
            }
            Console.Read();
        }
    }
}
