using System;
using System.Collections;
using System.Collections.Generic;

namespace T1907M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // TotalNumber();
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            // int no;
            // no = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(no);
            int f0 = 1;
            int f1 = 1;
            int fi = 1;
            while (f0 + f1 < i)
                
            {
                fi = f0 + f1;
                f0 = f1;
                f1 = fi;
            }
            Console.WriteLine("So fi bo sau n la");
        }

        // static void TotalNumber()
        // {
        //     int a = 2;
        //     int b = 3;
        //     a = b > 2 ? 2 : 1;
        //     int x;
        //     int[] ary = {1, 2, 3};
        //     for (int i = 0; i < 3; i++)
        //     {
        //         Console.WriteLine(i);
        //     }
        //
        //     foreach (int y in ary)
        //     {
        //         Console.WriteLine(y);
        //     }
        //
        //     double[] ary2 = new Double[5];
        //     ary2[0] = 2123;
        //     ary[1] = 341;
        //     List<int> list = new List<int>();
        //     list.Add(5);
        //     list[1] = 6;
        //     for (int i = 0; i < ary2.Length; i++)
        //     {
        //         Console.WriteLine(ary2[i]);
        //     }
        //     for (int i = 0; i < list.Count; i++)
        //     {
        //         Console.WriteLine(ary2[i]);
        //     }
        // }
    }
}