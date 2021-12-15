using System;
using System.Collections.Generic;
using System.Text;

namespace Gadgets
{
    public class Gadget
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Gadget()
        { }
        public void SetName(string newName)
        {
            Name = newName;
        }
    }
}
