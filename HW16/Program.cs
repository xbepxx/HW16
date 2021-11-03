using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace HW16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Product[] products = new Product[n];
            for (int i = 0; i < n; i++)
            {
                products[i] = new Product();
                Console.WriteLine($"Ввод данных продукта №{i+1}:");
                Console.Write("Введите код товара ");
                products[i].Code = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите наименование товара ");
                products[i].Name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите стоимость товара ");
                products[i].Price = double.Parse(Console.ReadLine());
            }
            string jsonString = JsonSerializer.Serialize(products);
            string path1 = "log";
            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }
            string path = "log/Products.json";
                if(!File.Exists(path))
            {
                File.Create(path);
            }
            File.WriteAllText(path, jsonString);
            string json = File.ReadAllText(path);
            Product[] product = JsonSerializer.Deserialize<Product[]>(json);
            Product P=new Product();
            double max = product[0].Price;
            //string m = "";
            //for (int i = 0; i < product.Length; i++)
            //{
            //    if (product[i].Price > max)
            //    {
            //        max = product[i].Price;
            //        m = product[i].Name;
            //    }
            //}
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].Price > max)
                {
                    max = product[i].Price;
                    P = product[i];
                }
            }
            Console.WriteLine($"Наименование самого дорогого товара: {P.Name}");
            //Console.WriteLine($"Наименование самого дорогого товара: {m}");
            //Console.WriteLine(json);
            //Console.WriteLine(product);
            Console.ReadKey();
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int code; //код товара
        private string name; //наименование товара
        private double price; //стоимость товара
        public int Code
        {
            set
            {
                code = value;
            }
            get
            {
                return code;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public double Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
    }
}
