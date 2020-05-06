using System;
using System.Threading;

namespace buoi2.Ss8
{
    public class Threadd
    {
        private int number = 0;
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(run);
            t1.Start();
            Thread t2 = new Thread(new Threadd().run2);
            t2.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Hello Word");
                Thread.Sleep(100);
            }

        }

        public static void run(object o)// khong co tham so hoac co 1 tham so object
        {
            string msg = (string) o;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i :" + i);
                Thread.Sleep(100);
            }
        }
        public  void run2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" xyz = "+(number+=2));
                Thread.Sleep(100);
            }
        }
    }
}