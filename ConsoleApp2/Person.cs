using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Color FavouriteColor { get; set; }

        public Person(string eesnimi, string perenimi)
        {
            FirstName = eesnimi;
            LastName = perenimi;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    public enum Color
    {
        Teadmata,
        Punane,
        Oranž,
        Kollane,
        Roheline,
        Sinine,
        Lilla,
        Valge,
        Must
    }
}
