using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund02._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Cat cat = new Cat();

            Bird bird = new Bird();
            dog.Talk();
            Console.WriteLine();
            cat.Talk();
            Console.WriteLine();
            bird.Talk();
            Console.WriteLine();
            Console.WriteLine(bird.legN);

            Square square = new Square(2);
            Circle circle = new Circle(3);
            Rectangle rectangle = new Rectangle(2, 3);
            square.Area();
            square.Perimeter();
            Console.WriteLine(square.Type);
            circle.Area();
            circle.Perimeter();
            Console.WriteLine(circle.Type);
            rectangle.Area();
            rectangle.Perimeter();
            Console.WriteLine(rectangle.Type);
            Console.ReadKey();
        }
    }
}
