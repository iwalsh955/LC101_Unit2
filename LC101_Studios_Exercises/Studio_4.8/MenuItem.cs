using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_4._8
{
    class MenuItem
    {
        public double Price { get; set; }
        public string Desc { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public MenuItem(string name, double price, string desc, string cat)
        {
            this.Price = price;
            this.Desc = desc;
            this.Category = cat;
            this.Name = name;
        }
    }
}
