using System.Collections.Generic;

namespace buoi2.Asss4
{
    public class Custormer_international : Customer
    {
        private int total;
        private List<Custormer_international> _custormerInternationals;

        public Custormer_international(int total, List<Custormer_international> custormerInternationals)
        {
            this.total = total;
            _custormerInternationals = custormerInternationals;
        }

        public int Total
        {
            get => total;
            set => total = value;
        }

        public List<Custormer_international> CustormerInternationals
        {
            get => _custormerInternationals;
            set => _custormerInternationals = value;
        }

        public int Id1
        {
            get => id;
            set => id = value;
        }

        public string Name1
        {
            get => name;
            set => name = value;
        }

        public string RightOffTheBill1
        {
            get => right_off_the_bill;
            set => right_off_the_bill = value;
        }

        public double Dongia1
        {
            get => dongia;
            set => dongia = value;
        }

        public Custormer_international(int id, string name, string rightOffTheBill, double dongia, int total, List<Custormer_international> custormerInternationals) : base(id, name, rightOffTheBill, dongia)
        {
            this.total = total;
            _custormerInternationals = custormerInternationals;
        }
        
    }
}