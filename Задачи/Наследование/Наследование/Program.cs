using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Program
    {



        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();
            CandyProduct candy1 = new CandyProduct();
            candy1.Set("skittles", 200, 10);
            products.Add(candy1);

            CandyProduct candy2 = new CandyProduct();
            candy2.Set("Mars",200,20);
            products.Add(candy2);
            
            CandyProduct candy3 = new CandyProduct();
            candy3.Set("kit kat", 200, 150);
            products.Add(candy3);

            CandyProduct candy4 = new CandyProduct();
            candy4.Set("milky way", 200, 155);
            products.Add(candy4);

            CandyProduct candy5 = new CandyProduct();
            candy5.Set("milke", 200, 300);
            products.Add(candy5);

            CandyProduct candy6 = new CandyProduct();
            candy6.Set("baby fox", 200, 350);
            products.Add(candy6);

            IceCream_MoroZ_Product ice1 = new IceCream_MoroZ_Product();
            ice1.Set("Plombir", 100, 4);
            products.Add(ice1);

            IceCream_MoroZ_Product ice2 = new IceCream_MoroZ_Product();
            ice2.Set("Creme brulee", 100, 5);
            products.Add(ice2);

            IceCream_MoroZ_Product ice3 = new IceCream_MoroZ_Product();
            ice3.Set("Sorbet", 100, 10);
            products.Add(ice3);

            IceCream_MoroZ_Product ice4 = new IceCream_MoroZ_Product();
            ice4.Set("Fruit ice", 100 , 11);
            products.Add(ice4);

            foreach(Product product in products)
            {
                double cost = product.GetPrice() * product.GetCount();
                double discount = product.CalculateDiscount();
                double total = cost * (1 - discount / 100);

                Console.WriteLine("Название: " + product.GetName() + ", цена за единицу: " + product.GetPrice() + ", продано: " + product.GetCount() + ", стомость: " + cost + ", скидка: " + discount + "%" + ", сумма с учетом скидки: " + total);
            }
        }
    }
}
