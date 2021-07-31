using System;
using System.Globalization;
using System.Collections.Generic;
using Exc_Generics.Entities;
using Exc_Generics.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            //Reads the number of products
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter products(desc,price):");
            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list);

            Console.WriteLine("Most expensive item:");
            Console.WriteLine(p);
        }
    }
}