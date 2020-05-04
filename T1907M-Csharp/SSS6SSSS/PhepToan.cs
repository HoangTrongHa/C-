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
            return a / b;
        }
        public static NumberAdd NumberFunction (string Chucnang)
        {
            if (Chucnang == "Tong")
            {
                return Tong;
            }else if (Chucnang=="hieu")
            {
                return Hieu;
            }else if (Chucnang =="tich")
            {
                return Tich;
            }
            else
            {
                return Thuong;
            }
        }
    }
}