using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class Vowel
    {
        public void Check()
        {
            Console.WriteLine("Enter An Alphabet : ");
            char alphabet = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(alphabet))
            {
                case 'a' :
                    Console.WriteLine("It is vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is vowel");
                    break;
                default:
                    Console.WriteLine("It Is Consonent");
                    break;
            }
        }
    }
}
