using System;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Basic Core Programming");

            Console.WriteLine("1.Check It Is Head or tail :");
            Console.WriteLine("2.Check The Year Is Leap Or Not :");
            Console.WriteLine("3.Quotient and Reminder :");
            Console.WriteLine("4. Swap the Numbers :");
            Console.WriteLine("5.Check The Number is Even and Odd number :");
            Console.WriteLine("6.check alphabet Vowel Or Consonent :");
            Console.WriteLine("7.Greatest number among Three :");
            Console.WriteLine("8.Find Factors :");

            Console.WriteLine("Enter Your Choice :" );

            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    FlipCoin flipcoin = new FlipCoin();
                    flipcoin.Toss();
                    break;

                case 2:
                    LeapYear leapyear = new LeapYear();
                    leapyear.Year();
                    break;

                case 3:
                    Remainder remainder = new Remainder();
                    remainder.Compute();
                    break;

                case 4:
                    Swap swap = new Swap();
                    swap.Swapping();
                    break;

                case 5:
                    EvenOdd evenodd = new EvenOdd();
                    evenodd.Find();
                    break;
                case 6:
                    Vowel vowel = new Vowel();
                    vowel.Check();
                    break;
                case 7:
                    Greatest greatest = new Greatest();
                    greatest.Number();
                    break;
                case 8:
                    Factors factors = new Factors();
                    factors.factor();
                    break;
            }
        }
    }
}
