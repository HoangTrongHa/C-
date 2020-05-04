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

        }
       
    }
}