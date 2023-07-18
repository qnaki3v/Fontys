using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    internal class MissionControl
    {
        private List<Mission> missions;

        public MissionControl()
        {
            missions = new List<Mission>();
        }

        public void Add(Mission mission)
        {
            if (missions.Contains(mission))
            {
                return;
            }
            missions.Add(mission);
        }
        public Mission Get(string name)
        {
            foreach (Mission mission in missions)
            {
                if (mission.Name == name)
                {
                    return mission;
                }
            }
            return null;
        }
        
        public Mission[] GetAll()
        {
            return missions.ToArray();
        }
    }
}
