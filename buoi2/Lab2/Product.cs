using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace buoi2.Lab2
{
    public class Product
    {
        public int id;
        public string name;
        public int price;
        public int qty;
        public string img;
        public string desc;
        public List<string> gallery;

        public Product()
        {
        }

        public Product(int id, string name, int price, int qty, string img, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.img = img;
            this.desc = desc;
            this.gallery = gallery;
        }

        public void showInfor()
        {
            Console.WriteLine("Thong tin san pham"+name+price+qty+img+desc+gallery);
        }

        public void stock(int a)
        {
            if ( a <= qty)
            {
                Console.WriteLine("Con hang");
            }
            else
            {
                Console.WriteLine("Het hang");
            }
        }

        public void addGallery()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("them anh ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Da them vao thu vien"+i);
            }            
            
        }

        // public void removeGallery()
        // {
        //     Console.WriteLine("Nhap anh muon xoa");
        //     int n = Convert.ToInt32(Console.ReadLine());
        //     foreach( n in gallery.Count) 
        //     { 
        //         Console.WriteLine("Da xoa"+n); 
        //     } 
        //     
        //     foreach(int n in gallery) 
        //     { 
        //         Console.WriteLine(gallery); 
        //     } 


        }
    }
