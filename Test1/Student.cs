using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalCode { get; set; }
        public bool IsStudying { get; set; }

        public StudentStatus Status { get; set; }

        public Student(string firstName, string lastName, int personalCode, string status)
        {
            FirstName = firstName;
            LastName = lastName;
            Enum.TryParse(status, true, out StudentStatus studentStatus);
            Status = studentStatus;
            PersonalCode = personalCode;
            if (Status == StudentStatus.Õpib)
            {
                IsStudying = true;
            } else
            {
                IsStudying = false;
            }
        }

    }

    public enum StudentStatus
    {
        Õpib,
        Lõpetanud,
        Eksmatrikuleeritud,
        AkadeemiliselPuhkusel
    }
}
