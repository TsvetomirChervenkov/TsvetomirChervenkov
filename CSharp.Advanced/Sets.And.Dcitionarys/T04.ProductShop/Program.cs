using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shoping = new Dictionary<string, Dictionary<string, double>>();
            string input = "";
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] inputArgs = input.Split(", ");
                string shop = inputArgs[0];
                string product = inputArgs[1];
                double price = double.Parse(inputArgs[2]);

                if (!shoping.ContainsKey(shop))
                {
                    shoping.Add(shop, new Dictionary<string, double>());
                    shoping[shop].Add(product, price);
                }
                else
                {
                    shoping[shop].Add(product, price);
                }
            }
            
            foreach (var kvp in shoping.OrderBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key +"->");
                foreach (var prod in kvp.Value)
                {
                    Console.WriteLine($"Product: {prod.Key}, Price: {prod.Value}");
                }
            }
        }
    }
}
