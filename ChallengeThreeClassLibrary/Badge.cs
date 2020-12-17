using System;
using System.Collections.Generic;

namespace ChallengeThreeClassLibrary
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; }

        public Badge(int badgeID, List<string> doorNames)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }
        public Badge()
        {

        }
        public void AddDoor(string newDoor)
        {
            DoorNames.Add(newDoor);
        }
        public void RemoveDoor(string doorRemoved)
        {
            DoorNames.Remove(doorRemoved);
        }
    }
}
