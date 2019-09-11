using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeineTund
{
    class Food
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Food(string name, int price)
        {
            Name = name;
            Price = price;
        }

    }
}
