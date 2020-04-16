using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Moi nhap so n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int f = 0;
            int f1 = 1, f2 = 1 ;
            while (f1 + f2 < n)
            {
                f = f1 + f2;
                f2 = f1;
                f1 = f;
            }
            Console.WriteLine("Number =" + n + " Fibonacci = " + f);
        }
    }
}