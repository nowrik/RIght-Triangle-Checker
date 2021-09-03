using System;

namespace RIght_Triangle
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Value of side A of the triangle:");
            var SideA = double.Parse(Console.ReadLine());
            Console.Write("Enter Value of side B of the triangle:");
            var SideB = double.Parse(Console.ReadLine());
            Console.Write("Enter Value of side C of the triangle:");
            var SideC = double.Parse(Console.ReadLine());


            if (LeftHandSide(SideA, SideB) == RightHandSide(SideC))
            {
                Console.WriteLine("It is a right triangle.");
            }
            else 
            {
                Console.WriteLine("It is not a right triangle.");
            }
            Console.Read();
        }
        public static double LeftHandSide(double LHSA, double LHSB)
        {
            return (LHSA * LHSA) + (LHSB * LHSB);
            }
        public static double RightHandSide (double RHSA)
        {
            return RHSA * RHSA;
        }
    }
}
