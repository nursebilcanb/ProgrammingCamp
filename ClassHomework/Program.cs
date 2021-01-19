using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.Category = "Computer";
            product1.Brand = "Monster";
            product1.Price = 9000;

            Products product2 = new Products();
            product2.Category = "Television";
            product2.Brand = "Samsung";
            product2.Price = 6000;


            Products product3 = new Products();
            product3.Category = "Phone";
            product3.Brand = "Xiaomi";
            product3.Price = 4200;


            Products[] product = new Products[]
            {
                product1,product2,product3
            };


            foreach (var products in product)
            {
                Console.WriteLine(products.Brand + " : " + products.Price);
            }
            Console.ReadLine();
        }


        class Products
        {
            public string Category { get; set; }
            public string Brand { get; set; }
            public int Price { get; set; }
        }
    }
}
