using HAL_9000_Writting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HAL_9000 
{
    class circleAreaCalc 
    {
        public static void Calculate() 
        {
            float area;
            float pi;
            int radius;

            Console.WriteLine("What is the radius of the circle?");

            string radusInput = Console.ReadLine();

            try
            {
                radius = Convert.ToInt32(radusInput);
            }
            catch (Exception)
            {
                radius = 0;
                Writting.sorryDave();
                goto End;
            }

            pi = 3.1415926536f;
            area = pi * radius * radius;

            Console.WriteLine("The area of the circle is " + area);
        End: ;
        }
    }
}
