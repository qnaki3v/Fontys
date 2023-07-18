
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapAndInheritanceAnimals
{
    public class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name)
        {
            this.name = name;
            this.age = 1;
        }
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void CelebrateBirthday()
        {
            if (age + 1 < 101)
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
            return $"{name} ({age} year(s))";
        }
    }
}
