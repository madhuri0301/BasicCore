using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        int  year;

        public void Year()
        {
            Console.WriteLine("Enter The Year:");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) | year % 400 == 0)
            {
                Console.WriteLine("It Is Leap Year");
            }
            else
            {
                Console.WriteLine("It Is Not Leap Year");
            }

        }
    }
}
