using System;
using System.Collections.Generic;
using System.Text;

namespace Gadgets
{
    public interface IDetails
    {
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
    }
}
