using System;
using System.Collections.Generic;

namespace buoi2.Asss4
{
    public class Customer_inland : Customer
    {
        private double total;
       private List<Customer_inland> ListVn = new List<Customer_inland>();

       public Customer_inland(double total)
       {
           this.total = total;
       }

       public Customer_inland()
       {
       }

       public double Total
       {
           get => total;
           set => total = value;
       }

       public List<Customer_inland> ListVn1
       {
           get => ListVn;
           set => ListVn = value;
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

       public Customer_inland(int id, string name, string rightOffTheBill, double total,double dongia) : base(id, name, rightOffTheBill,dongia)
       {
           this.total = total;
       }

       public void addCustomer(Customer_inland Customer)
       {
           ListVn.Add(Customer);
       }
       public void use()
       {
           if (total < 50)
           {
               dongia  = total * 1000;
           }
           else
           {
               if ( 50 < total && total <100 )
               {
                   dongia = total * 1200;
               }
               else
               {
                   if (100 < total && total < 200)
                   {
                       dongia = total * 1500;
                   }
                   else
                   {
                       dongia = total * 2000;
                   }
               }
           }
           Console.WriteLine("So tien phai tra"+dongia);
       }
       
    }
}