using System;

namespace buoi2.Asss4
{
    public class Customer
    {
        protected int id;
        protected string name;
        protected string right_off_the_bill;
        protected double dongia;
        public Customer()
        {
        }

        public Customer(int id, string name, string rightOffTheBill,double dongia)
        {
            this.id = id;
            this.name = name;
            right_off_the_bill = rightOffTheBill;
            this.dongia = dongia;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string RightOffTheBill
        {
            get => right_off_the_bill;
            set => right_off_the_bill = value;
        }

        public double Dongia
        {
            get => dongia;
            set => dongia = value;
        }

        public void showInfor()
        {
            Console.WriteLine("Name"+name+"makhach hang"+id+"ngay ra bill"+right_off_the_bill);
        }
    }
}