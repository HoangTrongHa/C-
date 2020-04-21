using System;
using System.Collections.Generic;
using buoi2.Lab2;
using buoi2.SSS3SSSS;

namespace buoi2.Lab3
{
    public class Fashion : Product
    {
        protected string color;
        protected string size;
        public List<Fashion> listFashion=new List<Fashion>();

        public Fashion()
        {
        }
 
        public Fashion(string color, string size)
        {
            this.color = color;
            this.size = size;
        }
        public Fashion(int id, string name, int price, int qty, string img, string desc, List<string> gallery, string color, string size) : base(id, name, price, qty, img, desc, gallery)
        {
            this.color = color;
            this.size = size;
        }
        public void descColor()
        {
            
        }
        public void ShowFashion()
        {
            Console.WriteLine("Fashion List:");
            foreach (Fashion f in productList)
            {
                Console.WriteLine("ID:" + id + " - Name: " + name + " - Price: " + price + " - Qty: " + qty +
                                  " - Desc: " + desc + " - Color: " + color + " - Size " + size);
            }
        }

        public void checkFashion()
        {
            string name;
            Console.WriteLine("San pham can tim: ");
            name = Convert.ToString(Console.ReadLine());
            foreach (Fashion f in productList)
            {
                if (name.Equals(f.name))
                {
                    if (f.qty > 0)
                    {
                        Console.WriteLine("Con hang");
                        string color;
                        Console.WriteLine("Mau can tim: ");
                        color = Convert.ToString(Console.ReadLine());
                        if (color.Equals(f.color))
                        {
                            Console.WriteLine("ID:" + id + " - Name: " + name + " - Price: " + price + " - Qty: " +
                                              qty +
                                              " - Desc: " + desc + " - Color: " + color + " - Size " + size);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Het hang");
                    }
                }
            }
        }
    }
}