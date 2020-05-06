using System;

namespace buoi2.SSS6SSSS
{
    public class Programs
    {
        //khai bao 1 delegate tra ve int 2 tham so int
        
        public delegate int DetegateAdd(int a, int b);

        public delegate float AddSalary(float salary);
        public static void Main(string[] args)
        {//tao 1 doi tuong delegate
            
            DetegateAdd ii =new DetegateAdd(Calculator.Add);
            ii += Calculator.Stru;
            ii += new Calculator().division;
            ii(2, 4);//nap vao delegate
            // TaxMoney a = new TaxMoney();();
            
            AddSalary ss = new AddSalary(TaxCalc.vietNam);
            ss(10023);
            
            
            TaxMoney tm = TaxCalc.GetTax("VN");// la 1 delegate
            float tax = tm(10000);
            Console.WriteLine("Thue phai nop"+tax);

            TaxMoney tm2 = TaxCalc.GetTax("Us");// la 1 delegate
            float tax2 = tm2(10000);
            Console.WriteLine("Thue phai nop"+tax2);

            TaxMoney tm3 = TaxCalc.GetTax("sadas");// la 1 delegate
            float tax3 = tm3(10000);
            Console.WriteLine("Thue phai nop"+tax3);

            //an danh
            TaxMoney tm4 = delegate(float salary) { return salary * 40 / 100;};
            float tax4 = tm4(341);
            Console.WriteLine("Thue phai nop tai phap"+tax4);
            
            //tu lam
            // int chose = 0;
            // NumberAdd p ;
            // Console.WriteLine("Thue phai nop"+tax3);
            // do
            // {
            //     Console.WriteLine("1. Cong");
            //     Console.WriteLine("2. Tru");
            //     Console.WriteLine("3. Nhan ");
            //     Console.WriteLine("4. Chia");
            //     Console.WriteLine("Chose: ");
            //     chose = Convert.ToInt32(Console.ReadLine());
            //     switch (chose)
            //     {
            //         case 1:
            //              p = PhepToan.NumberFunction("Tong");
            //             break;
            //         case 2:
            //             p = PhepToan.NumberFunction("hieu");
            //             break;
            //         case 3:
            //             p = PhepToan.NumberFunction("tich");
            //             break;
            //         case 4:
            //             p = PhepToan.NumberFunction("Thuong");
            //             break;
            //         case 5:
            //             Environment.Exit(0);
            //             break;
            //     }
            // } while (chose != 5);
            // NumberAdd tm5 = PhepToan.NumberFunction("Tong");// la 1 delegate
            // float tax5 = tm5(123,3123);
            // Console.WriteLine("Tong = "+tax5);
            //
            // NumberAdd tm6 = PhepToan.NumberFunction("hieu");// la 1 delegate
            // float tax6 = tm6(123,3123);
            // Console.WriteLine("hieu = "+tax6);
            //
            // NumberAdd tm7 = PhepToan.NumberFunction("tich");// la 1 delegate
            // float tax7 = tm7(123,3123);
            // Console.WriteLine("Tich = "+tax7);
            //
            // NumberAdd tm8 = PhepToan.NumberFunction("Thuong");// la 1 delegate
            // float tax8 = tm8(1123123,3123);
            // Console.WriteLine("thuong = "+tax8);
            
            //thay chua
            int choose;
            do
            {
                showMenu();
                choose = readNumber();
                if (choose > 0 && choose < 5)
                {
                    Console.WriteLine("nhap so thu nhat:");
                    int no1 = readNumber();
                    Console.WriteLine("nhap so thu hai:");
                    int no2 = readNumber();
                    NumberAdd mn = PhepToan.NumberFunction(choose);
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Tong 2 so:" + mn(no1, no2));
                            break;
                        case 2:
                            Console.WriteLine("Hieu 2 so:" + mn(no1, no2));
                            break;
                        case 3:
                            Console.WriteLine("Tich 2 so:" + mn(no1, no2));
                            break;
                        case 4:
                            Console.WriteLine("Thuong 2 so:" + mn(no1, no2));
                            break;
                    }
                }
            } while (choose != 0);
        }

        public static void showMenu()
        {
            Console.WriteLine("Lua chon chua nang");
            Console.WriteLine("1 Cong");
            Console.WriteLine("2 Tru ");
            Console.WriteLine("3 Nhan ");
            Console.WriteLine("4 Chia");
            Console.WriteLine("0 thoat");
        }

        public static int readNumber()
        {
return Convert.ToInt32(Console.ReadLine());
        }
    }
}