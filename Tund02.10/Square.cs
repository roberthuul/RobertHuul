using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund02._10
{
    class Square:Rectangle
    {
        public string Type = "Ruut";
        public double Side { get; set; }

        public Square(double a, double b = 0): base(a,b)
        {
            Side = a;
        }

        public override void Area()
        {
            Console.WriteLine("Pindala = " + Side * Side);
        }

        public override void Perimeter()
        {
            Console.WriteLine("Ümbermõõt = " + 4 * Side);
        }
    }
}
