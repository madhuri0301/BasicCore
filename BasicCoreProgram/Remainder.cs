using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class Remainder
    {
        public void Compute()
        {
            Console.WriteLine("Enter The Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient :" + Quotient);
            Console.WriteLine("remainder :" + remainder);
        }
    }
}
