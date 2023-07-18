using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapAndInheritanceAnimals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            this.name = name;
        }
        public Dog(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public override void CelebrateBirthday()
        {
            if (age + 1 < 20)
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
            return $"Dog:{name} ({age} year(s))";
        }
    }
}
