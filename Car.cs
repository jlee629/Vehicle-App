using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp
{
    class Car : Vehicle
    {
        public const double INTEREST = 15;

        public string Fuel { get; set; }
        public int NumberOfPassengers { get; set; }

        public Car(string name,
            string brand, 
            double price, 
            int warranty, 
            string store, 
            int numberOfPassengers, 
            string fuel) : base(name, brand, price, warranty, store)
        {
            NumberOfPassengers = numberOfPassengers;
            Fuel = fuel;
        }

        public override string Operate()
        {
            return "You turn on the ignition!";
        }

        public override double CalculateInterest()
        {
            return (Price * INTEREST) / 100;
        }
    }
}
