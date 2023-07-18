using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_MissionControl
{
    internal class AstronautStatistics
    {
        public Mission[] MissionHistory { get; private set; } // private set is used when we have a public property but we dont want the outside to set it
        public int TotalDaysInSpace { get; private set; }
        public Astronaut[] TravelledWith { get; private set; }
        public Mission LongestMission { get; private set; }

        public AstronautStatistics(Astronaut target, Mission[] missions)
        {
            DetermineMissionHistory(target, missions);
            CalculateTotalDaysInSpace();
            DetermineFellowAstronauts(target);
            DetermineMissionHistory();
        }
        private void DetermineMissionHistory(Astronaut target, Mission[] missions)
        {
            List<Mission> missionHistory = new List<Mission>();
            foreach (Mission mission in missions) 
            {
                if (mission.HasAstronaut(target))
                {
                    missionHistory.Add(mission);
                }
            }
            MissionHistory = missionHistory.ToArray();
        }
        private void CalculateTotalDaysInSpace()
        {
            int sum = 0;
            foreach (Mission mission in MissionHistory) 
            {
                sum += mission.CalculateDaysInSpace();
            }
            TotalDaysInSpace = sum;
        }
        private void DetermineFellowAstronauts(Astronaut target)
        {
            HashSet<Astronaut> fellowAstronauts = new HashSet<Astronaut>();
            foreach (Mission mission in MissionHistory)
            {
                fellowAstronauts.UnionWith(mission.GetAllAstronauts());
            }
            fellowAstronauts.Remove(target);
            TravelledWith = fellowAstronauts.ToArray();
        }
        private void DetermineMissionHistory()
        {
            int max = 0;
            int indexOfMax = 0;
            for (int i = 0; i < MissionHistory.Length; i++)
            {
                int daysInSpace = MissionHistory[i].CalculateDaysInSpace();
                if (daysInSpace > max)
                {
                    indexOfMax = i;
                    max = daysInSpace;
                }
            }
            LongestMission = MissionHistory[indexOfMax];
        }
    }
}
