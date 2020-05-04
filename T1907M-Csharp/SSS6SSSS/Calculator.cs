using System;

namespace buoi2.SSS6SSSS
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine(a+b);
            return a + b;
        }

        public static int Stru(int a, int b)
        {
            Console.WriteLine(a-b);
            return a - b;
        }

        public int division(int a, int b)
        {           
            if (b == 0) return 0;
            Console.WriteLine(a/b);
            return a / b;
        }
    }
}