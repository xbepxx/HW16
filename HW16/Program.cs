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
            //Console.WriteLine("Введите код товара");
            //int code=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите наименование товара");
            //string name= Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Введите стоимость товара");
            //double price = Convert.ToDouble(Console.ReadLine());
            //Product product1 = new Product(code, name, price);
            //Product product2 = new Product(code, name, price);
            //Product product3 = new Product(code, name, price);
            //Product product4 = new Product(code, name, price);
            //Product product5 = new Product(code, name, price);
            int n = 5;
            Product[] products = new Product[5];

            for (int i = 0; i < n; i++)
            {
                products[i] = new Product();
                //Console.WriteLine("Ввод данных");
                Console.WriteLine("Введите код товара");
                products[i].code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите наименование товара");
                products[i].name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите стоимость товара");
                products[i].price = double.Parse(Console.ReadLine());
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
            Product product = JsonSerializer.Deserialize<Product>(json);
            //int maxValue = product.Max<int>();




            //StreamWriter sw = new StreamWriter(path, true)
            //    sw.
            //string path = "log/Products.json";
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            //StreamWriter sw = new StreamWriter(path, true);
            //sw.
            //Console.ReadKey();
        }
    }
    class Product
    {
        public int code; //код товара
        public string name; //наименование товара
        public double price; //стоимость товара
        public void SetCode (int code)
        {
            this.code = code;
        }
        public void SetName(int Name)
        {
            this.name = name;
        }
        public void SetPrice(int code)
        {
            this.price = price;
        }
        //public int code { set; get; } //код товара
        //public string name { set; get; } //наименование товара
        //public double price { set; get; } //стоимость товара
        //public Product(int code, string name, double price)
        //{
        //    this.code = code;
        //    this.name = name;
        //    this.price = price;
        //}
        //public void Print()
        //{
        //    Console.WriteLine($"код товара {code},наименование товара {name}, стоимость товара {price}");
        //}
    }
}
