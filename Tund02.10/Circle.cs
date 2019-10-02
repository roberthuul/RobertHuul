using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund02._10
{
    class Circle:Shape
    {
        public double Radius { get; set; }

        public string Type = "Ring";

        public Circle(double r)
        {
            Radius = r;
        }

        public override void Area()
        {
            Console.WriteLine("Pindala = " + Math.PI * Radius * Radius);
        }

        public override void Perimeter()
        {
            Console.WriteLine("Ümbermõõt = " + 2 * Math.PI * Radius);
        }
    }
}
