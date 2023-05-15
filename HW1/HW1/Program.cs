using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the diameter of your desired pizza: ");
            float diameter = float.Parse(Console.ReadLine());

            double pi = 3.14159;
            double pizzaSliceArea = 14.125;
            float r = diameter / 2;
            double pizzaTotalArea = pi * Math.Pow(r, 2);

            float calculate = (float)(pizzaTotalArea / pizzaSliceArea);
            Console.WriteLine("The number of slices will be: " + calculate);

            if (calculate >= 3 && calculate <= 5)
            {
                Console.WriteLine("It's a small pizza.");
            }
            else if (calculate >= 6 && calculate <= 8)
            {
                Console.WriteLine("It's a medium pizza.");
            }
            else if (calculate >= 9 && calculate <= 10)
            {
                Console.WriteLine("It's a large pizza.");
            }
            else
            {
                Console.WriteLine("Size not supported.");
            }
        }
    }
}
