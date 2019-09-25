using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Group(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            student.IsStudying = true;
            student.Status = StudentStatus.Õpib;
            Students.Add(student);
        }

        public void PrintGroup()
        {
            Console.WriteLine("Grupi nimi: " + Name + "\nÕpilased:");
            foreach (var item in Students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            
        }

        public void RemoveStudent()
        {
            Console.Write("Sisesta õpilase eesnimi: ");
            string firstName = Console.ReadLine();
            Console.Write("Sisesta õpilase perekonnanimi: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Sisesta põhjus:\n1 - lõpetanud\n2 - eksmatrikuleeritud");
            string reason = Console.ReadLine();
            for (int i = 0; i < Students.Count; i++)
            {
                if (firstName == Students[i].FirstName && lastName == Students[i].LastName)
                {
                    if (reason == "1")
                    {
                        Students[i].Status = StudentStatus.Lõpetanud;
                    } else if (reason == "2")
                    {
                        Students[i].Status = StudentStatus.Eksmatrikuleeritud;
                    }
                    Students[i].IsStudying = false;
                    Students.Remove(Students[i]);
                    
                    Console.WriteLine($"{firstName} {lastName} eemaldati grupist {Name}");
                }
            }
        }
    }
}
