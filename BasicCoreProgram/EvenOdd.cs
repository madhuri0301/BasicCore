using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class EvenOdd
    {
        int a;
        public void Find()
        {
            Console.WriteLine("Enter the Value : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

        }
    }
}
