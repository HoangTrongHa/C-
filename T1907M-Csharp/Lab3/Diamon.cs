using System;
using System.Collections.Generic;
using buoi2.Lab2;

namespace buoi2.Lab3
{
    public class Diamon : Product
    {
                public int cara;
                public List<Diamon> diamonList = new List<Diamon>();

                public Diamon()
                {
                }

                public Diamon(int cara)
                {
                    this.cara = cara;
                }

                public Diamon(int id, string name, int price, int qty, string img, string desc, List<string> gallery, int cara) : base(id, name, price, qty, img, desc, gallery)
                {
                    this.cara = cara;
                }
                public void addDiamon(int cara)
                {
                    foreach (Product p in productList)
                    {
                        if (name.Equals(p.name))
                        {
                            return;
                        }
                    }

                    diamonList.Add(new Diamon(cara));
                    ;
                }
                public void ShowDiamon()
                {
                    Console.WriteLine("Diamon List:");
                    foreach (Diamon d in diamonList)
                    {
                        Console.WriteLine("ID:" + id + " - Name: " + name + " - Price: " + price + " - Qty: " + qty +
                                          " - Desc: " + desc + " - Cara: " + cara);
                    }
                }

                public void check()
                {
                    string name;
                    Console.WriteLine("San pham can tim: ");
                    name = Convert.ToString(Console.ReadLine());
                    foreach (Diamon d in diamonList)
                    {
                        if (name.Equals(d.name))
                        {
                            if (d.qty > 0)
                            {
                                Console.WriteLine("Con hang");
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