using System;

namespace Area_of_a_Circle
{
    class Program
    {
        public class Circle
        {
            public static double GetArea(string radius)
            {
                double area = Math.PI * Math.Pow(double.Parse(radius), 2);
                return area;
            }

            public static double GetCircumference(string radius)
            {
                double circumference = 2 * Math.PI * int.Parse(radius);
                return circumference;
            }

            public static double GetDiameter(string radius)
            {
                double diameter = 2 * double.Parse(radius);
                return diameter;
            }

        }
        static void Main(string[] args)
        {
            string radius;
            bool isNumber;
            do
            {
                Console.WriteLine("Enter a radius: ");
                radius = Console.ReadLine();
                isNumber = double.TryParse(radius, out _);

                if (!isNumber)
                {
                    Console.WriteLine("incorrect input");
                    Environment.Exit(0);
                }


            }
            while (double.Parse(radius) < 0);

            //Console.WriteLine("Enter a radius: ");
            //string radius = Console.ReadLine();

            //double area = Math.PI * Math.Pow(double.Parse(radius),2);
            //Console.WriteLine("The area of a circle of radius "+ radius + " is " +Math.Round(area, 3));

            //double circumference = 2 * Math.PI * int.Parse(radius);
            //Console.WriteLine("The circumference of a circle of radius " + radius + " is " + Math.Round(circumference, 3));

            //double diameter = 2 * double.Parse(radius);
            //Console.WriteLine("The diameter of a circle of radius " + radius + " is " + Math.Round(diameter, 3));

            //Console.WriteLine("Enter a Mile-Per-Gallon of your car: ");
            //string mpg = Console.ReadLine();

            //double gallons = circumference / double.Parse(mpg);
            //Console.WriteLine("It will take " + Math.Round(gallons, 2) + " gallons to go around this circle.");


            Console.WriteLine("The area of a circle of radius " + radius + " is " + Math.Round(Circle.GetArea(radius), 3));
            Console.WriteLine("The circumference of a circle of radius " + radius + " is " + Math.Round(Circle.GetCircumference(radius), 3));
            Console.WriteLine("The diameter of a circle of radius " + radius + " is " + Math.Round(Circle.GetDiameter(radius), 3));

            Console.WriteLine("Enter a Mile-Per-Gallon of your car: ");
            string mpg = Console.ReadLine();

            //double gallons = Circle.GetCircumference(radius) / double.Parse(mpg);
            //Console.WriteLine("It will take " + Math.Round(gallons, 2) + " gallons to go around this circle.");
         
            
            //Console.WriteLine(isNumber);
        }
    }
}
