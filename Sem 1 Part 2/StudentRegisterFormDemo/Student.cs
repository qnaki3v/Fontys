using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegisterFormDemo
{
    public class Student
    {
        public Student(string name, string email, string pcn)
        {
            Name= name;
            Email= email;
            PCN= pcn;
        }

        public string Name;
        public string Email;
        public string PCN;
    }
}
