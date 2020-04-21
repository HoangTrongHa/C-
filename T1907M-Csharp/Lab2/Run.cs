using System;
namespace buoi2.Lab2

{
    public class Run
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
                int chose = 0;
                do
                {
                    Console.WriteLine("1. Addproduct");
                    Console.WriteLine("2. GetInfo");
                    Console.WriteLine("3. CheckStock");
                    Console.WriteLine("4. Add IMG");
                    Console.WriteLine("5. Remove IMG");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Chose: ");
                    chose = Convert.ToInt32(Console.ReadLine());
                    switch (chose)
                    {
                        case 1:
                            product.addProduct(product);
                            break;
                        case 2:
                            product.showInfor();
                            break;
                        case 3:
                            product.stock();
                            
                            break;
                        case 4:
                            product.addGallery();
                            break;
                        case 5:
                            product.removeGallery();
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                    }
                } while (chose != 5);
            }
        }
    }