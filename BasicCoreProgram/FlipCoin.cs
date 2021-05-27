using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        int n = 10;
        int Head_Count = 0;
        int Tail_Count = 0;

        public void Toss()
        {
            for (int i = 1; i <= n; i++)
            {
                Random random = new Random();
                int toss = random.Next(0, 2);
                if (toss > 0.5)
                {
                    Tail_Count++;
                }
                else
                {
                    Head_Count++;
                }
            }
            Console.WriteLine("Head_Count is :" + Head_Count);
            Console.WriteLine("Tail_Count is :" + Tail_Count);

            int Percent_Head = (Head_Count * 100) / 10;
            int Percent_Tail = (Tail_Count * 100) / 10;

            Console.WriteLine("The Percentage of Head is : " + Percent_Head);
            Console.WriteLine("The Percentage of Tail is : " + Percent_Tail);

        }
    }
}