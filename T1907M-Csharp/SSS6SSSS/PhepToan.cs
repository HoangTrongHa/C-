using System;

namespace buoi2.SSS6SSSS
{
    public delegate int NumberAdd(int a, int b);

    public class PhepToan
    {
        public static int Tong(int a, int b)
        {
            return a + b;
        }
        public static int Hieu(int a, int b)
        {
            return a - b;
        }
        public static int Tich(int a, int b)
        {
            return a * b;
        }
        public static int Thuong(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Sai mm r");
                throw;
            }
        }
        public static NumberAdd NumberFunction (int  Choose)
        {
            switch (Choose)
            {
                case 1: return Tong;
                case 2: return Hieu;
                case 3: return Tich;
                case 4: return Thuong;
default: return null;
            }
        }
    }
}