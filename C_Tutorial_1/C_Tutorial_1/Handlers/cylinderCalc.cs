using HAL_9000_Writting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    class cylinderCalc
    {
        public static void Calculate()
        {
            string radiusAsAString;
            string heightAsAString;
            double surfaceArea;
            double radius;
            double height;
            double volume;
            double pi;

            Console.WriteLine("Cylinder Calculation as you requested.");

            Console.Write("Please tell me it's radius: ");
            try
            {
                radiusAsAString = Console.ReadLine();
                radius = Convert.ToDouble(radiusAsAString);
            }
            catch
            {
                radius = 0;
                Writting.sorryDave();
                goto End;
            }

            Console.Write("Please tell me it's hight: ");
            try
            {
                heightAsAString = Console.ReadLine();
                height = Convert.ToDouble(heightAsAString);
            }
            catch
            {
                height = 0;
                Writting.sorryDave();
                goto End;
            }

            pi = 3.1415926536;

            volume = pi * radius * radius * height;
            surfaceArea = 2 * pi * radius * (radius + height);

            Console.WriteLine("It's volume is:  " + volume + " cubic meters.");
            Console.WriteLine("It's surface area is:  " + surfaceArea + " square meters.");
        End: ;
        }
    }
}
