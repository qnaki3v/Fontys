using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    internal class AstronautControl
    {
        private List<Astronaut> astronauts;

        public AstronautControl()
        {
            astronauts = new List<Astronaut>();
        }

        public void Add(Astronaut astronaut)
        {
            if (astronauts.Contains(astronaut))
            {
                return;
            }
            astronauts.Add(astronaut);
        }
        public Astronaut Get(string name)
        {
            foreach (Astronaut astronaut in astronauts)
            {
                if (astronaut.Name == name) 
                { 
                    return astronaut; 
                }              
            }
            return null;
        }
        public Astronaut Get(int id)
        {
            foreach (Astronaut astronaut in astronauts)
            {
                if (astronaut.Id == id)
                {
                    return astronaut;
                }
            }
            return null;
        }
        public Astronaut[] GetAll()
        {
            return astronauts.ToArray();
        }
    }
}
