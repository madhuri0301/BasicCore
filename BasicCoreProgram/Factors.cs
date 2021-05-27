using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class Factors
    {
        int num, i;
        public void factor()
        {
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors Are :");
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
