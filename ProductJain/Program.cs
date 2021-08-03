using System;
using System.Collections.Generic;

namespace ProductJain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Console.WriteLine("------Product Details------");
            bool showMenu = true;
            Console.WriteLine("------SMARTPHONE STORE------");

            while(showMenu)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Add a Product: ");
                Console.WriteLine("2. Display all prodcts: ");
                Console.WriteLine("3. Delete a product: ");
                Console.WriteLine("4. Delete all products.");
                Console.WriteLine("5. Exit.");

                Console.WriteLine("Enter the option: ");
                int option = Int16.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter Product Id: ");
                    int id = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Product name: ");
                    String name = (Console.ReadLine());

                    Console.WriteLine("Enter Product model: ");
                    String model = (Console.ReadLine());

                    Console.WriteLine("Enter Product Specifications: ");
                    String specifications = (Console.ReadLine());

                    Console.WriteLine("Enter Product Price");
                    int price = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Product Color: ");
                    String color = Console.ReadLine();

                    Product obj = new Product();
                    obj.id = id;
                    obj.name = name;
                    obj.price = price;
                    obj.color = color;
                    obj.model = model;
                    obj.specifications = specifications;

                    product.Add(obj);
                    Console.WriteLine("Product added successfully!!!");
                    Console.ReadLine();
                }

                else if (option == 2)
                {
                    foreach (Product obj in product)
                    {
                        Console.WriteLine("------------");
                        Console.WriteLine("Product ID: " + obj.id);
                        Console.WriteLine("Product Name: " + obj.name);
                        Console.WriteLine("Product Model: " + obj.model);
                        Console.WriteLine("Product Specifications: " + obj.specifications);
                        Console.WriteLine("Product Price: " + obj.price);
                        Console.WriteLine("Product Color: " + obj.color);
                        Console.WriteLine("------------");
                    }
                }

                else if (option == 3)
                {
                    Console.WriteLine("Enter the index of the product you wish to delete");
                    int index = Int16.Parse(Console.ReadLine());
                    product.RemoveAt(index);
                    Console.WriteLine("Product deleted successfully!!!");

                    Console.WriteLine("Remaining number of products : " + product.Count);
                    Console.ReadLine();
                }
            }
        }
    }
}















