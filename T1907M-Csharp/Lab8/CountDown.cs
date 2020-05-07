using System;
using System.Threading;

namespace buoi2.Lab8
{
    public class CountDown
    {

        public static void Main(string[] args)
        {
            Thread count1 = new Thread(CountDownThreadt);
            count1.Start();
            // Thread count2 = new Thread(CountDownThreadt1);
            // count2.Start();
        }

        public static void CountDownThreadt()
        {    
            int count1 = 10;
            int count2 = 60;
            int count3 = 120;
            for (int i = count1; i >= 0; i--)
            {
                for (int j = count2; j >= 0; j--)
                {
                    for (int k = count3; k >= 0; k--)
                    {
                        //keyword number format 01 02 03 c#
                        Console.WriteLine(i+" : "+j+":"+k);
                        Thread.Sleep(10);
                    }
                  
                }
            }
            Console.WriteLine("Bommmmm");

        }
//         public static void CountDownThreadt1()
//         {
//             int count1 = 10;
//             for (int i = count1; i > 0; i--)
//             {
//                 Thread.Sleep(1000);
//             }
// Console.WriteLine("Bommmmm");
//         }
     }
}