using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeineTund
{
    class DetailedShoppingCart
    {
        List<Food> Items { get; set; }

        List<int> Kogused { get; set; }

        public int Summa { get; set; }

        public DetailedShoppingCart()
        {
            Items = new List<Food>();
            Kogused = new List<int>();
        }

        public void LisaKorvi(Food toit, int kogus)
        {
            Items.Add(toit);
            Kogused.Add(kogus);
            Summa = Summa + toit.Price * kogus;

        }

        public void Näita()
        {
            /*
            int a = 0;
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(Kogused[a]);
                a++;
            }
            */
            Console.WriteLine("Summa: " + Summa);
        }
    }
}
