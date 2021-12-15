using System;
using System.Collections.Generic;
using System.Text;

namespace Gadgets
{
    class Laptops:IDetails
    {
        public Laptops(string brand, int price, int year, string type, string processor, double storage, double screenSize)
        {
            Brand = brand;
            Price = price;
            Year = year;
            Type = type;
            Processor = processor;
            Storage = storage;
            ScreenSize = screenSize;
        }

        public string Brand { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }

        public string Processor { get; set; }
        public double Storage { get; set; }
        public double ScreenSize { get; set; }

        public void UpgradeProcessor(string newProcessor)
        {
            Processor = newProcessor;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Type: {Type}, Year: {Year}, Price: {Price}, Processor: {Processor}, Storage: {Storage}, Screensize: {ScreenSize}";
        }

    }
}
