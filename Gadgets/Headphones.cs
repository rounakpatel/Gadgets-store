using System;
using System.Collections.Generic;
using System.Text;

namespace Gadgets
{
    public class Headphones : IDetails
    {
        public Headphones(string brand, int price, int year, string type, bool noiseCancellation, bool wired, bool chargeable)
        {
            Brand = brand;
            Price = price;
            Year = year;
            Type = type;
            NoiseCancellation = noiseCancellation;
            Wired = wired;
            Chargeable = chargeable;
        }

        public string Brand { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }

        public bool NoiseCancellation { get; set; }
        public bool Wired { get; set; }
        public bool Chargeable { get; set; }

        public void UpgradePrice(int newPrice)
        {
            Price = newPrice;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, Type: {Type}, Year: {Year}, Price: {Price}, NoiseCancellation: {NoiseCancellation}, Wired: {Wired}, Chargeable: {Chargeable}";
        }

    }
}
