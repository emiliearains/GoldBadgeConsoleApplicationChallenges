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
            DoorNames = new List<string>();
        }
        public void AddDoor(string newDoor)
        {
            DoorNames.Add(newDoor);
        }
        public void RemoveDoor(string doorRemoved)
        {
            DoorNames.Remove(doorRemoved);
        }
        public string GetFormattedDoorList()
        {
            string returnstring = "";
            foreach (string str in DoorNames)
            {
                returnstring = returnstring + str + " ";
            }
            return returnstring;
        }
    }
}
