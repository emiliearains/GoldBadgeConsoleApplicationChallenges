using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeThreeClassLibrary
{
    public class BadgeRepository
    {
        private Dictionary<int, Badge> dictBadges;
        public BadgeRepository()
        {
            dictBadges = new Dictionary<int, Badge>();
        }
        // Create
        public void AddBadge(Badge newBadge)
        {
            dictBadges.Add(newBadge.BadgeID, newBadge);
        }
        // Read
        public Dictionary<int,Badge> ViewBadges()
        {
            return dictBadges;
        }
        public Badge GetBadgesByBadgeID(int id)
        {
            return dictBadges[id];
        }
        // Update
        public bool UpdateBadge(Badge updatedBadge)
        {
            // Badge existingBadge = GetBadgesByBadgeID(updatedBadge.BadgeID);
            if (dictBadges.ContainsKey(updatedBadge.BadgeID))
            {
                dictBadges[updatedBadge.BadgeID] = updatedBadge;
                return true;
            }
            else
            {
                return false;
            }
        }
        // Delete --> don't need for this challenge
       





    }
}
