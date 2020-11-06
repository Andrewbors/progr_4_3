using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Func
    {
        private static int n = 5;

        public static Product[] ReadProductsArray()
        {
            Product[] products = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name: ");
                String name = Console.ReadLine();

                Console.WriteLine("Currency: ");
                String currencyName = Console.ReadLine();

                Console.WriteLine("Exchange rate: ");
                double exRate = Convert.ToDouble(Console.ReadLine());

                Currency cost = new Currency(currencyName, exRate);

                Console.WriteLine("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Weight: ");
                int weight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Producer: ");
                String producer = Console.ReadLine();

                Console.WriteLine("Vyberit odynyci vymiriuvannya terminy prydatnosti(0-days, 1-months, 2-years): ");
                int od = Convert.ToInt32(Console.ReadLine());

                if (od == 0)
                {
                    Console.WriteLine("Vvedit kilkist dniv: ");
                }
                else if (od == 1)
                {
                    Console.WriteLine("Vvedit kilkist misyatsiv: ");
                }
                else if (od == 2)
                {
                    Console.WriteLine("Vvedit kilkist rokiv: ");
                }

                int termin = Convert.ToInt32(Console.ReadLine());
                bool a = false;

                if (od == 0)
                {
                    a = true;
                }
                else if (od == 1)
                {
                    termin *= 30;
                }
                else if (od == 2)
                {
                    termin *= 365;
                }

                products[i] = new Product(name, cost, price, quantity, weight, producer, termin);
            }

            return products;
        }

        public static void PrintProduct(Product product)
        {
            Console.WriteLine($"Name: {product.getName()}");
            Console.WriteLine($"Currency: {product.getCost().getName()}");
            Console.WriteLine($"Exchange rate: {product.getCost().getExRate()}");
            Console.WriteLine($"Quantity: {product.getQuantity()}");
            Console.WriteLine($"Weight: {product.getWeight()}");
            Console.WriteLine($"Producer: {product.getProducer()}");
            Console.WriteLine($"Termin: {product.getTermin()} days");
        }

        public static void PrintProducts(Product[] products)
        {
            foreach (Product p in products)
            {
                PrintProduct(p);
                Console.WriteLine("");
            }
        }

        public static Product[] GetProductsInfo(Product[] products)
        {
            Product min = products[0];
            Product max = products[0];

            for (int i = 0; i < products.Length; i++)
            {
                if (min.getPrice() > products[i].getPrice())
                {
                    min = products[i];
                }

                if (max.getPrice() < products[i].getPrice())
                {
                    max = products[i];
                }
            }

            Product[] result = { min, max };
            return result;
        }

        public static Product[] GetProductsByPrice(Product[] products)
        {
            for (int i = 1; i < products.Length; i++)
            {
                for (int j = 0; j < products.Length - 1; j++)
                {
                    if (products[j].getPrice() < products[j + 1].getPrice())
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            return products;
        }

        public static Product[] GetProductsByCount(Product[] products)
        {
            for (int i = 1; i < products.Length; i++)
            {
                for (int j = 0; j < products.Length - 1; j++)
                {
                    if (products[j].getQuantity() < products[j + 1].getQuantity())
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            return products;
        }

        public Func()
        {
            Product[] products = ReadProductsArray();
            PrintProducts(products);
        }
    }
}
