using System;
using System.Threading;

namespace buoi2.Ss8
{
    public class NumberCounter
    {
        public static void Main(string[] args)
        {
           NumberCounter nc = new NumberCounter();
           Thread t1 = new Thread(Run4);
           Thread t2 = new Thread(Run4);
           t1.Start(nc);
           t2.Start(nc);
        }

        public int x = 0;
        public int y = 0;

public void Show()
        {
            Console.WriteLine("x="+x);
            Console.WriteLine("y="+y);

        }

public void Change()
{
    x++;
    y++;
}
        public static void Run4(object o)
        {
            NumberCounter nc = (NumberCounter) o;
            for (int i = 0; i < 100; i++)
            {
                lock (nc)
                {
                    nc.Change();
                    nc.Show();
                }
               Thread.Sleep(100);
            }
        }
    }
    
}