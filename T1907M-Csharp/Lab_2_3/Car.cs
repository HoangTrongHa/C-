using System;
using System.Collections.Generic;

namespace buoi2.Lab_2_3
{    public delegate void ShowAl(string msg);

    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> listProduct;
        private string city;
        private string country;
        private event ShowAl AddToCart;

        public Cart(int id, string customer, double grandTotal, List<Product> listProduct, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.listProduct = listProduct;
            this.city = city;
            this.country = country;
            if (AddToCart == null)
            {
                AddToCart += AlertMessage;
            }
        }
        public static void AlertMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        private event ShowAl AddtoCard;
        
        public bool AddProduct(Product product)
        {
            listProduct.Add(product);
            // them tien trong grandTotal
            
            // phat su kien da them san pham

            AddtoCard("Da the san pham" + product.Name + "Vao gio hang");
            return true;
        }

        public bool RemoveProduct(Product product)
        {
            // tru tien trong grandTotal
            return listProduct.Remove(product);
        }

        public double FinalTotal()
        {
            double grand = 0;
            foreach (Product p in listProduct)
            {
                grand += p.price;
            }

            grand += ShippingFee(grand);
            this.grandTotal = grand;
            return grandTotal;
        }

        public double ShippingFee(double grand)
        {
            if(country.Equals("VN") && (city.Equals("HN") || city.Equals("HCM")))
            {
                return grand*0.01;
            }
            
            if (country.Equals("VN"))
            {
                return grand * 0.02;
            }
            
            return grand * 0.05;
            
        }
    }
}