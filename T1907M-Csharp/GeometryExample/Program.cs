using System;
using buoi2.SSS6SSSS;

namespace buoi2.GeometryExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            int weight;
            Lion l = new Lion(100, "Lion");
            Tiger t = new Tiger(100, "Tiger");
            l.Show();
            t.Show();
            int choose = 1;
            Console.WriteLine("nhap Radius:");
            int no1 = readNumber();
            Console.WriteLine("nhap Chieu cao:");
            int no2 = readNumber();
            Number mn = Cylinder.Result(choose);
            do
            {
                showMenu();
                choose = readNumber();
                if (choose > 0 && choose < 5)
                
                {
                   
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("BaseArea:" + mn(no1,no2));
                            break;
                        case 2:
                            Console.WriteLine("LateralArea:" + mn(no1, no2));
                            break;
                        case 3:
                            Console.WriteLine("TotalArea:" + mn(no1, no2));
                            break;
                        case 4:
                            Console.WriteLine("Volume:" + mn(no1, no2));
                            break;
                    }
                }
            } while (choose != 0);
        }
        public static void showMenu()
        {
            Console.WriteLine("Lua chon chua nang");
            Console.WriteLine("1 BaseArea");
            Console.WriteLine("2 LateralArea ");
            Console.WriteLine("3 TotalArea ");
            Console.WriteLine("4 Volume");
            Console.WriteLine("0 thoat");
        }

        public static int readNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        }
    }
