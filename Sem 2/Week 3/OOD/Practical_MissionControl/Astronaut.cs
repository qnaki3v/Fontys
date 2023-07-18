using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    internal class Astronaut
    {
        public int Id { get; }
        public string Name { get; }
        private char gender;
        private string nationality;
        public Astronaut(int id, string name, char gender, string nationality)
        {
            Id = id;
            Name = name;
            this.gender = gender;
            this.nationality = nationality;
        }
        public override string ToString() 
        {
            return $"Astronaut: {Name}, {gender}, {nationality}";
        }
    }
}
