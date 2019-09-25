using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Robert", "Huul", 1, "õpib");
            Student student2 = new Student("Kevin", "Saar", 2, "akadeemiliselpuhkusel");
            Student student3 = new Student("Heino", "Pärnpuu", 3, "õpib");

            Group targe18 = new Group("TARge18");

            targe18.AddStudent(student1);
            targe18.AddStudent(student2);
            targe18.AddStudent(student3);

            targe18.PrintGroup();

            targe18.RemoveStudent();

            Console.WriteLine(student1.IsStudying);
            Console.WriteLine(student1.Status);

            targe18.PrintGroup();

            Console.ReadKey();
        }
    }
}
