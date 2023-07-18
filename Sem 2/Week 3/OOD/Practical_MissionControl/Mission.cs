using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Practical_MissionControl
{
    internal class Mission
    {
        public string Name { get; }
        private DateTime launchDate;
        private DateTime returnDate;
        private string spaceship;
        private List<Astronaut> astronauts;

        public Mission(string name, DateTime launchDate, DateTime returnDate, string spaceship, List<Astronaut> astronauts)
        {
            Name = name;
            this.launchDate = launchDate;
            this.returnDate = returnDate;
            this.spaceship = spaceship;
            this.astronauts = astronauts;
        }

        public void AddAstronaut(Astronaut astronaut)
        {
            if (astronauts.Contains(astronaut))
            {
                return;
            }
            astronauts.Add(astronaut);
        }
        public Astronaut[] GetAllAstronauts() 
        { 
            return astronauts.ToArray();
        }
        public int CalculateDaysInSpace()
        {
            return returnDate.Subtract(launchDate).Days;
        }
        public bool HasAstronaut(Astronaut target)
        {
            return astronauts.Contains(target);
        }
        public override string ToString() 
        {
            return $"Mission: {Name}, {launchDate}, {returnDate}, {spaceship}";
        }
    }
}
