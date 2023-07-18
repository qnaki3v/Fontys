using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapAndInheritanceAnimals
{
    public class Turtle : Animal
    {
        public Turtle(string name) : base(name)
        {
            this.name = name;
        }
        public Turtle(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Turtle:{name} ({age} year(s))";
        }
    }
}
