using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class Greatest
    {
        int a, b, c;
        public void Number()
        {
            Console.WriteLine("Value Of A : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value Of B : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value Of C : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("A is Greater Number" );
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is Greater Number");
            }
            else
            {
                Console.WriteLine("C is Greater Number");
            }
        }
    }
}
