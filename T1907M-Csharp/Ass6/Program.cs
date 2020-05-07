using System;
using System.Threading;

namespace buoi2.Ass6
{
    public class Program
    {
        public static void Fibonaci(object o )
        {
            int n = (int) o;
            int x1 = 0;
            int x2 = 1;
            int x3 = 1;
            for (;x1+x2<n;)
            {
                x1 = x2;
                x2 = x3;
                x3 = x1 + x2;
                Thread.Sleep(100);
            }
            Console.WriteLine("So can tim"+x3);
        }

        public static void numBer()
        {
            for (int i = 0; ; i++)
            {
                for (int j = 0; j<60 ; j++)
                {
                    Console.WriteLine(i.ToString(("D2"))+":"+j.ToString(("D2")));
                    Thread.Sleep(100);
                }
            }
        }

        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Fibonaci);
            Thread t2 = new Thread(numBer);

            t2.IsBackground = true;
            
            Console.WriteLine("Nhap so n");
            int n = Convert.ToInt32(Console.ReadLine());

            t1.Start(n);
            
            t2.Start();
        }
    }
}