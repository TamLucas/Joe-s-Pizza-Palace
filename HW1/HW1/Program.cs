using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the diameter of your desired pizza: ");
            float diameter = Console.ReadLine();

            double pi = 3.14159;
            double pizzaSliceArea = 14.125;
            double pizzaTotalArea = (pi *  Math.Pow(r, 2));
            float r = diameter / 2;

            float calculate = (diameter * pizzaSliceArea);
            Console.WriteLine("The number of slices will be " + calculate);

            if(calculate == 3 or 4 or 5)
            {
                Console.WriteLine("It's a small pizza");
            }
            if(calculate == 6 or 7 or 8)
            {
                Console.WriteLine("It's a medium pizza");
            }
            if(calculate == 9 or 10)
            {
                 Console.WriteLine("It's a large pizza");
            }
            else
            {
                Console.WriteLine("Size not supported");
            }
        }


    }
}
