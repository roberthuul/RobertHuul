using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeineTund
{
    class Program
    {
        static void Main(string[] args)
        {
            Food sweets = new Food("Sweets", 5);
            //Console.WriteLine(sweets.Name);
            Food puder = new Food("Puder", 2);
            Food praad = new Food("Seapraad", 7);

            Food[] söögid = { sweets, puder, praad };


            DetailedShoppingCart uusKorv = new DetailedShoppingCart();

            uusKorv.LisaKorvi(praad, 3);
            uusKorv.LisaKorvi(puder, 4);

            uusKorv.Näita();

            Console.ReadKey();
        }
    }
}
