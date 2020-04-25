  
using System;
using System.Collections.Generic;
namespace buoi2.Lab_2_3
{
    public class Product
    {
         protected int id;
        protected string name;
        public double price;
        protected uint qty;
        protected string image;
        protected string desc;
        protected List<string> gallery;

        public Product()
        {
            this.gallery = new List<string>();
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

        public double Price
        {
            get => price;
            set => price = value;
        }

        public uint Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            set => gallery = value;
        }

        public Product(int id, string name, double price, uint qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public string this[int index]
        {
            get { return gallery [index];}
            set { gallery[index] = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine("ID: " + this.id + " Name:" + name + " qty: " + qty + " price:" + price + " desc: " + desc);
        }

        public bool CheckStock()
        {
            if (qty > 0) return true;
            return false;
        }

        public bool AddGallery(string image)
        {
            if (gallery.Count >= 10)
            {
                Console.WriteLine("Anh da vuot qua so luong, can xoa bot di truoc khi them");
                return false;
            }
            // Console.WriteLine("Nhap link anh:");    
            // string new_image = Console.ReadLine();
            // gallery.Add(new_image);
            gallery.Add(image);
            return true;
        }

        public void DeleteGallery()
        {
            Console.WriteLine("danh sach anh:");
            for (int i=0;i<  gallery.Count;i++)
            {
                Console.WriteLine(i+"."+gallery[i]);
            }
            Console.WriteLine("Chon anh de xoa:");
            int stt = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(stt);
        }

        public bool DeleteImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool DeleteAt(int number)
        {
            if (number < gallery.Count && number>=0)
            {
                gallery.RemoveAt(number);
                return true;
            }
            return false;
        }
    }
}