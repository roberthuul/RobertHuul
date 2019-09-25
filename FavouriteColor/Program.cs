using ConsoleApp2;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteColor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            //string[] lines = File.ReadAllLines(@"C:\Users\opilane\Desktop\list.txt");
            string[] lines = File.ReadAllLines("list.txt");

            foreach (var item in lines)
            {
                var names = item.Split(' ');
                Person person = new Person(names[0], names[1]);
                people.Add(person);
            }
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            //foreach (var item in people)
            //{
            //    if (lastName == item.LastName)
            //    {
            //        Console.WriteLine("Tere, " + item.FirstName);
            //    }
            //}

            Person someone = people.FirstOrDefault(x => x.LastName == lastName);
            Console.WriteLine($"Tere, {someone.FirstName}! Mis on sinu lemmikvärv?");
            var answer = Console.ReadLine();

            Enum.TryParse(answer, true, out Color favouriteColor);
            someone.FavouriteColor = favouriteColor;

            using (StreamWriter file = new StreamWriter("list2.txt"))
            {
                file.WriteLine($"{someone.FirstName} {someone.LastName}, lemmikvärv: {someone.FavouriteColor}");
            }

            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName; // töökataloogi asukoht
            using (StreamWriter file = new StreamWriter(path))
            {
                file.WriteLine($"{someone.FirstName} {someone.LastName}, lemmikvärv: {someone.FavouriteColor}");
            }
            //Console.ReadKey();
        }
    }
}
