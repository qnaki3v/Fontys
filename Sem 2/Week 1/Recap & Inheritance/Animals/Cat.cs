using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapAndInheritanceAnimals
{
    public class Cat : Animal
    {
        public Cat(string name) : base (name)
        {
            this.name = name;
        }
        public Cat(string name, int age) : base (name, age)
        {
            this.name = name;
            this.age = age;
        }

        public override void CelebrateBirthday()
        {
            if (age + 1 < 25)
            {
                this.age++;
                Console.WriteLine("Happy birthday!");
            }
            else
            {
                Console.WriteLine("Too old.");
            }
        }

        public override string ToString()
        {
            return $"Cat:{name} ({age} year(s))";
        }
    }
}
