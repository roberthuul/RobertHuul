using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund02._10
{
    class Rectangle:Shape
    {

        public double SideA { get; set; }

        public double SideB { get; set; }

        public string Type = "Ristkülik";

        public Rectangle(double a, double b)
        {
            SideA = a;
            SideB = b;
        }

        public override void Area()
        {
            Console.WriteLine("Pindala = " + SideA * SideB);
        }

        public override void Perimeter()
        {
            Console.WriteLine("Ümbermõõt = " + (2*SideA + 2*SideB));
        }
    }
}
