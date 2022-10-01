using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp
{
    abstract class Vehicle : ISellable
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Store { get; set; }
        public int Warranty { get; set; }

        public abstract string Operate();

        public Vehicle(string name, 
            string brand, 
            double price, 
            int warranty, 
            string store)
        {
            Brand = brand;
            Name = name;
            Price = price;
            Warranty = warranty;
            Store = store;        
        }

        public string MakeSale()
        {
            return "This is how we make a sale!";
        }

        public abstract double CalculateInterest();
    }
}
