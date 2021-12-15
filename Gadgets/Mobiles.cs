using System;
using System.Collections.Generic;
using System.Text;

namespace Gadgets
{
    class Mobiles:IDetails
    {
        public Mobiles(string brand, int price, int year, string type, bool touchScreen, double screenSize, bool dualSim)
        {
            Brand = brand;
            Price = price;
            Year = year;
            Type = type;
            TouchScreen = touchScreen;
            ScreenSize = screenSize;
            DualSim = dualSim;
        }

        public string Brand { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }

        public bool TouchScreen { get; set; }
        
        public double ScreenSize { get; set; }
        public bool DualSim { get; set; }

        public void UpgradePrice(int newPrice)
        {
            Price = newPrice;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Type: {Type}, Year: {Year}, Price: {Price}, TouchScreen: {TouchScreen}, ScreenSize: {ScreenSize}, Dual Sim: {DualSim}";
        }
    }
}
