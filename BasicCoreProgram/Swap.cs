using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class Swap
    {
        int a = 5,b = 10;

        public void Swapping()
        {
            Console.WriteLine("Before swapping a=" +a+ "b=" +b);
            a = a * b;
            b= a / b;
            a = a / b;
            Console.WriteLine("After swapping a=" +a+ "b=" +b);
        }
    }
}
